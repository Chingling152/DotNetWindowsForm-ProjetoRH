using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Senai.Projetos.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto.Senai.Projetos.Dao {
    class DependenteDao : IDao<Dependente> {

        //conexão com banco de dados
        private SqlConnection connection;

        //instrução sql
        private string sql = null;

        //mensagem
        private string msg = null;
        private string titulo = null;

        //construtor
        public DependenteDao() {
            connection = new ConectionFactory().GetConnection();
        }

        public List<Dependente> Consultar() {
            sql = "SELECT * FROM DependenteView";

            List<Dependente> depen = new List<Dependente>();

            try {
                //abre uma conexão com o banco de dados (mesma coisa do FuncDao)
                connection.Open();

                //cria um comando sql
                SqlCommand cmd = new SqlCommand(sql, connection);

                //cria um leitor pra receber os dados da tabela
                SqlDataReader leitor = cmd.ExecuteReader();

                while(leitor.Read()) {
                    //define os dados do dependente
                    Dependente dep = new Dependente();
                    dep.ID = (long)leitor["IDDependente"];
                    dep.Nome = leitor["NomeDependente"].ToString();
                    dep.Cpf = leitor["CpfDependente"].ToString();
                    dep.Data = (DateTime)leitor["DataNascimento"];
                    //define os dados da dependencia
                    Dependencia t = new Dependencia();
                    dep.Dependencia = t; //associa a dependencia ao dependente
                    t.Id = (long)leitor["IDDependencia"];
                    t.Descricao = leitor["Descricao"].ToString();
                    //define os dados do funcionario
                    Funcionario fun = new Funcionario();
                    dep.Funcionario = fun;//associa o funcionario ao dependente
                    fun.ID = (long)leitor["IDFuncionario"];
                    fun.Nome = leitor["NomeFuncionario"].ToString();
                    fun.Rg = leitor["Rg"].ToString();
                    fun.Telefone = leitor["Telefone"].ToString();
                    fun.Cpf = leitor["CpfFuncionario"].ToString();
                    fun.Email = leitor["Email"].ToString();
                    depen.Add(dep);
                }
            } catch(SqlException ex) {
                msg = "Erro ao consultar os dependentes \nErro : " + ex.Message;
                MessageBox.Show(msg, "Erro....", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } finally {
                connection.Close();
            }
            return depen;
        }

        public void Excluir(Dependente t) {
            sql = "DELETE FROM Dependente WHERE IDDependente = @id";

            try{
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql,connection);

                cmd.Parameters.AddWithValue("@id",t.ID);

                cmd.ExecuteNonQuery();

                msg = "Dependente " + t.Nome + " Excluido Com Sucesso";
                titulo = "Sucesso";

                //MESSAGEBOX
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch(SqlException ex){
                msg = "Erro Ao Excluir Dependente \n" + ex.Message;
                titulo = "Erro Nº " + ex.ErrorCode.ToString();

                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally{
                connection.Close();
            }
        }

        public void Salvar(Dependente t) {
            if(t.ID != 0) {
                sql = "UPDATE Dependente SET Nome = @nome , Cpf = @cpf , DataNascimento = @data , IDFuncionario = @idf , IDDependencia = @idd WHERE IDDependente = @IDDependente";

            } else {
                sql = "INSERT INTO Dependente (Nome , Cpf , DataNascimento ,IDFuncionario,IDDependencia) VALUES(@nome,@cpf,@data,@idf,@idd)";
            }

            try {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@nome", t.Nome);
                cmd.Parameters.AddWithValue("@cpf", t.Cpf);
                cmd.Parameters.AddWithValue("@data",t.Data);
                cmd.Parameters.AddWithValue("@idf", t.Funcionario.ID);
                cmd.Parameters.AddWithValue("@idd", t.Dependencia.Id);
                cmd.Parameters.AddWithValue("@IDDependente", t.ID);

                cmd.ExecuteNonQuery();

                msg = "Dependencia Salva Com Sucesso";
                titulo = "Sucesso...";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            } catch(SqlException ex) {
                msg = "Erro Ao Salvar Dependencia : " + ex.Message;
                titulo = "Erro : " + ex.ErrorCode.ToString();
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } finally {
                connection.Close();
            }

        }
    }
}
