using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Senai.Projetos.Modelos;
using System.Data.SqlClient;

namespace Projeto.Senai.Projetos.Dao {
    class FuncDao : IDao<Funcionario> {
        //conexão com o banco de dados
        private SqlConnection connection;
        //intrução sql
        private string sql = null;
        //mensagem do messagebox
        private string msg = null;
        //titulo da messagebox
        private string titulo = null;

        public FuncDao(){
            connection = new ConectionFactory().GetConection();
        }

        //metodos herdados da interface IDao
        public List<Funcionario> Consultar() {
            throw new NotImplementedException();
        }

        public void Excluir(Funcionario fun) {
            throw new NotImplementedException();
        }

        public void Salvar(Funcionario fun) {
            try{
                sql = "INSERT INTO Funcionario(Nome,Cpf,Rg,Email,Telefone) VALUES(@Nome,@Cpf,@Rg,@Email,@Telefone)";
                //abre uma conexão com o banco de dados
                connection.Open();
                //cria comando sql
                SqlCommand cmd = new SqlCommand(sql,connection);
                //ATRIBUI VALORES A STRING SQL
                cmd.Parameters.AddWithValue("@Nome",fun.Nome_);
                cmd.Parameters.AddWithValue("@Cpf",fun.Cpf_);
                cmd.Parameters.AddWithValue("@Rg",fun.Rg_);
                cmd.Parameters.AddWithValue("@Email",fun.Email_);
                cmd.Parameters.AddWithValue("@Telefone",fun.Telefone_);
                //EXECUTA A STRING SQL
                cmd.ExecuteNonQuery();

                msg = "Funcionario " + fun.Nome_ + " Salvo Com Sucesso";
                titulo = "Salvo...";

                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(SqlException e){
                msg = "Erro Ao Salvar Funcionario" + e.Message;
                titulo = "Erro...";
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally{
                connection.Close();
            }
        }
    }
}
