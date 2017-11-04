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
        
        //construtor
        public DependenteDao(){
            connection = new ConectionFactory().GetConection();
        }

        public List<Dependente> Consultar() {
            sql = "SELECT FROM DependenteView";

            List<Dependente> depen = new List<Dependente>();

            try{
                //abre uma conexão com o banco de dados (mesma coisa do FuncDao)
                connection.Open();

                //cria um comando sql
                SqlCommand cmd = new SqlCommand(sql,connection);

                //cria um leitor pra receber os dados da tabela
                SqlDataReader leitor = cmd.ExecuteReader();

                while(leitor.Read()){
                //define os dados do dependente
                    Dependente dep = new Dependente();
                        dep.ID = (long)leitor["IDDependente"];
                        dep.Nome = leitor["NomeDependente"].ToString();
                        dep.Cpf = leitor["CpfDependente"].ToString();
                        dep.Data = (DateTime)leitor["Nascimento"];
                //define os dados da dependencia
                    Dependencia t = new Dependencia();
                        dep.Depe = t; //associa a dependencia ao dependente
                        t.Id = (long)leitor["IDDependencia"];
                        t.Descricao = leitor["Descricao"].ToString();
                //define os dados do funcionario
                    Funcionario fun = new Funcionario();
                        dep.Func = fun;//associa o funcionario ao dependente
                        fun.ID = (long)leitor["IDFuncionario"];
                        fun.Nome = leitor["Nome"].ToString();
                        fun.Rg = leitor["Rg"].ToString();
                        fun.Telefone = leitor["Telefone"].ToString();
                        fun.Cpf = leitor["Cpf"].ToString();
                        fun.Email = leitor["Email"].ToString();
                    depen.Add(dep);
                }
            }
            catch(SqlException ex){
                msg = "Erro ao consultar os dependentes \nErro : " + ex.Message;
                MessageBox.Show(msg,"Erro....",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally{
                connection.Close();
            }
            return depen;
        }

        public void Excluir(Dependente t) {
            throw new NotImplementedException();
        }

        public void Salvar(Dependente t) {
            throw new NotImplementedException();
        }
    }
}
