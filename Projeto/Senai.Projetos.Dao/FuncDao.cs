using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Senai.Projetos.Modelos;
using System.Data.SqlClient;

namespace Projeto.Senai.Projetos.Dao {
    class FuncDao : IDao<Funcionario> { // ele herda da InterfaceDao
        //conexão com o banco de dados
        private SqlConnection connection;
        //intrução sql
        private string sql = null;
        //mensagem do messagebox
        private string msg = null;
        //titulo da messagebox
        private string titulo = null;

        //constructor
        public FuncDao(){
            connection = new ConectionFactory().GetConnection();
        }

        //metodos herdados da interface IDao

        public List<Funcionario> Consultar() {
            //codigo sql armazenado numa string
            sql = "SELECT * FROM Funcionario";

            //cria uma lista pra armazenar as variaveis
            List<Funcionario> funcs = new List<Funcionario>();

            //tenta
            try {
                //abrir a conexão com o banco
                connection.Open();

                //comando sql
                SqlCommand cmd = new SqlCommand(sql,connection);

                //cria um leitor de dados
                SqlDataReader leitor = cmd.ExecuteReader();
                    
                //enquanto o leitor tiver dados para ler
                while(leitor.Read()){
                    //cria um novo objeto do tipo funcionario
                    Funcionario f = new Funcionario(){
                        //atribui valor as propriedades do objeto funcionario
                        ID = (long) leitor["IDFuncionario"],
                        Nome = leitor["Nome"].ToString(),
                        Cpf = leitor["CPF"].ToString(),
                        Rg = leitor["RG"].ToString(),
                        Email = leitor["Email"].ToString(),
                        Telefone = leitor["Telefone"].ToString()
                    };
                    //adiciona funcionario lista de funcionarios
                    funcs.Add(f);
                }
            } 
            catch(SqlException e){
                msg = "Erro Ao Consultar Funcionarios Cadastrados \n" +e.Message;
                titulo = "Erro : " + e.ErrorCode.ToString();
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }           
            finally {
                connection.Close();
            }
            return funcs;
        }

        public void Excluir(Funcionario fun) {
            //instrução sql
            sql = "DELETE FROM Funcionario WHERE IDFuncionario = @id";

            try{
                //abre a conexão com o banco de dados
                connection.Open();

                //cria um comando sql
                SqlCommand cmd = new SqlCommand(sql,connection);

                //adiciona valor ao parametro @ID
                cmd.Parameters.AddWithValue("@id",fun.ID);

                //executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //mensagem de feedback
                msg = "Funcionario " + fun.Nome + " Excluido Com Sucesso";
                titulo = "Sucesso";

                //MESSAGEBOX
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            } 
            catch(SqlException ex){
                //mensagem de erro 
                msg = "Erro Ao Excluir Funcionario/n" + ex.Message;
                titulo = "Erro : " + ex.ErrorCode.ToString();

                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } 
            finally{
                //fecha a conexão com o banco de dados
                connection.Close();
            }
        }

        public void Salvar(Funcionario fun) {

            if(fun.ID != 0){
                //atualiza se não for igual a 0
                sql = "UPDATE Funcionario SET Nome=@Nome,Cpf=@Cpf,Rg=@Rg,Email=@Email,Telefone=@Telefone WHERE IDFuncionario = @ID";
            }else{
                //cria for igual a 0 
                //seta a string como um comando de sql
                sql = "INSERT INTO Funcionario(Nome,Cpf,Rg,Email,Telefone) VALUES(@Nome,@Cpf,@Rg,@Email,@Telefone)";
            }

            try{               
                //abre uma conexão com o banco de dados
                connection.Open();
                //cria comando sql
                SqlCommand cmd = new SqlCommand(sql,connection);
                //ATRIBUI VALORES A STRING SQL
                cmd.Parameters.AddWithValue("@ID", fun.ID);
                cmd.Parameters.AddWithValue("@Nome",fun.Nome);
                cmd.Parameters.AddWithValue("@Cpf",fun.Cpf);
                cmd.Parameters.AddWithValue("@Rg",fun.Rg);
                cmd.Parameters.AddWithValue("@Email",fun.Email);
                cmd.Parameters.AddWithValue("@Telefone",fun.Telefone);
                //EXECUTA A STRING SQL
                cmd.ExecuteNonQuery();

                msg = "Funcionario " + fun.Nome + " Salvo Com Sucesso";
                titulo = "Salvo...";

                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch(SqlException e){
                msg = "Erro Ao Salvar Funcionario" + e.Message;
                titulo = "Erro : " + e.ErrorCode.ToString();
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally{
                connection.Close();
            }
        }

        public Funcionario Consulta(string par){
            //comando sql
            sql = "SELECT * FROM Funcionario WHERE Cpf = @Cpf";

            //cria um novo objeto do tipo funcionario (com valor nulo pra poder ter um valor armazenado mais tarde)
            Funcionario f = null;

            //tenta
            try {
                //abrir uma conexão com o banco de dados
                connection.Open();

                //  Criar um comando sql na conexão connection
                SqlCommand cmd = new SqlCommand(sql,connection);

                //adciona parametros no comando sql
                cmd.Parameters.AddWithValue("@Cpf",par);

                //leitor sql (recebe os dados do banco de dados)
                //que esta sendo executado pelo cmd
                SqlDataReader leitor = cmd.ExecuteReader();

                //enquanto tiver dados para ler 
                while (leitor.Read()){
                    //se tem alguma linha que contenha a coluna cpf 
                    if(par.Equals(leitor["Cpf"].ToString())){
                        //cria um objeto na variavel nula
                        f = new Funcionario() {
                            //atribui valor as propriedades do objeto funcionario
                            ID = (long)leitor["IDFuncionario"],
                            Nome = leitor["Nome"].ToString(),
                            Cpf = leitor["CPF"].ToString(),
                            Rg = leitor["RG"].ToString(),
                            Email = leitor["Email"].ToString(),
                            Telefone = leitor["Telefone"].ToString()
                        };
                    }
                }
            } catch (SqlException ex){
                msg = "Erro Ao Consultar Funcionario \n"+ex.Message;
                titulo = "Erro : " + ex.ErrorCode.ToString();
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }finally{
                connection.Close();
            }
            return f;
            
        }
    }
}
