using System;
using Projeto.Interfaces;
using Projeto.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto.Dao {
    class DependenteDao : IDao<Dependente> , IDependente{

        //conexão com banco de dados
        private SqlConnection connection;

        //instrução sql
        private string sql = null;

        //mensagem
        private string msg = null;
        private string titulo = null;

        //construtor
        public DependenteDao() {
            connection = new ConnectionFactory().GetConnection();
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
                    Dependente dep = new Dependente {
                        ID = (long)leitor["IDDependente"],
                        Nome = leitor["NomeDependente"].ToString(),
                        Cpf = leitor["CpfDependente"].ToString(),
                        Data = (DateTime)leitor["DataNascimento"]
                    };
                    //define os dados da dependencia
                    Dependencia t = new Dependencia();
                    dep.Dependencia = t; //associa a dependencia ao dependente
                    t.ID = (long)leitor["IDDependencia"];
                    t.Descricao = leitor["Descricao"].ToString();
                    //define os dados do funcionario
                    Funcionario fun = new Funcionario(
                        id: (long)leitor["IDFuncionario"],
                        nome: leitor["NomeFuncionario"].ToString(),
                        cpf: leitor["CpfFuncionario"].ToString(),
                        rg: leitor["Rg"].ToString(),
                        email: leitor["Email"].ToString(),
                        telefone: leitor["Telefone"].ToString()
                    );
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

        public Dependente Consultar(long id) {
            throw new NotImplementedException();
        }

        public void Excluir(long id) {
            sql = "DELETE FROM Dependente WHERE IDDependente = @id";

            try{
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql,connection);

                cmd.Parameters.AddWithValue("@id",ID);

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
                cmd.Parameters.AddWithValue("@idd", t.Dependencia.ID);
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

        public List<Dependente> VerDependentes(long IDFuncionario) {
            throw new NotImplementedException();
        }
    }
}
