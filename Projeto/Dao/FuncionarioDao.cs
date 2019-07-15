using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Projeto.Enums;
using Projeto.Modelos;
using Projeto.Interfaces;

namespace Projeto.Dao {
    /// <summary>
    /// Classe responsavel por manipular dados referente aos Funcionarios
    /// </summary>
    class FuncionarioDao :  IFuncionario{ // ele herda da Interface IFuncionario que herda de IDao
        //conexão com o banco de dados
        private readonly SqlConnection connection;

       /// <summary>
       /// Construtor da classe Funcionario Dao
       /// </summary>
        public FuncionarioDao() {
            this.connection = ConnectionFactory.GetConnection();
        }

        /// <summary>
        /// Procura e retorna todos os funcionarios cadastrados no banco de dados
        /// </summary>
        /// <returns>Uma lista com todos os funcionarios cadastrados</returns>
        public List<Funcionario> Consultar() {
            //cria uma lista pra armazenar as variaveis
            List<Funcionario> funcs = new List<Funcionario>();

            //tenta
            try {
                //abrir a conexão com o banco
                connection.Open();

                //comando sql
                SqlCommand cmd = new SqlCommand("EXEC VerTodosFuncionarios", connection);

                //cria um leitor de dados
                SqlDataReader leitor = cmd.ExecuteReader();
                    
                //enquanto o leitor tiver dados para ler
                while(leitor.Read()){
                    //cria um novo objeto do tipo funcionario
                    Funcionario f = new Funcionario(
                            id: (long)leitor["REGISTRO_FUNCIONARIO"],
                            idPessoa: (long)leitor["ID_FUNCIONARIO"], 
                            nome: leitor["NOME_FUNCIONARIO"].ToString(),
                            cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                            rg: leitor["RG_FUNCIONARIO"].ToString(),
                            email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                            telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                            dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                            funcao: new Funcao(
                                ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                                Descricao: leitor["DESCRICAO"].ToString(),
                                CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                                cargo: new Cargo(
                                    ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                    Nome: leitor["CARGO"].ToString()
                                )
                            ),
                            salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                            situacao: (EnSituacaoFuncionario)Convert.ToInt32(leitor["SITUACAO_FUNCIONARIO"])
                        );
                    //adiciona funcionario lista de funcionarios
                    funcs.Add(f);
                }
            } 
            catch(SqlException ex){
               throw ex;
            }           
            finally {
                connection.Close();
            }
            return funcs;
        }

        /// <summary>
        /// Procura um funcionario com o CPF selecionado
        /// </summary>
        /// <param name="cpf">CPF do funcionario a ser procurado</param>
        /// <returns>Um funcionario que tenha o CPF inserido por parametro</returns>
        public Pessoa Consultar(string cpf) {
            try {
                //abrir uma conexão com o banco de dados
                connection.Open();

                //  Criar um comando sql na conexão connection
                SqlCommand cmd = new SqlCommand("EXEC VerFuncionarioCpf @CPF", connection);

                //adciona parametros no comando sql
                cmd.Parameters.AddWithValue("@CPF", cpf);

                //leitor sql (recebe os dados do banco de dados)
                //que esta sendo executado pelo cmd
                SqlDataReader leitor = cmd.ExecuteReader();

                //enquanto tiver dados para ler 
                while (leitor.Read()) {
                    //se tem alguma linha que contenha a coluna cpf 
                    //retorna o funcionario criado
                    return new Funcionario(
                        id: (long)leitor["REGISTRO_FUNCIONARIO"],
                        idPessoa: (long)leitor["ID_FUNCIONARIO"],
                        nome: leitor["NOME_FUNCIONARIO"].ToString(),
                        cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                        rg: leitor["RG_FUNCIONARIO"].ToString(),
                        email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                        telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                        dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                        funcao: new Funcao(
                            ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                            Descricao: leitor["DESCRICAO"].ToString(),
                            CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                            cargo: new Cargo(
                                ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                Nome: leitor["CARGO"].ToString()
                            )
                        ),
                        salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                        situacao: (EnSituacaoFuncionario)Convert.ToInt32(leitor["SITUACAO_FUNCIONARIO"])
                    );

                }
            } catch (SqlException) {
                throw new Exception("Erro ao se conectar no banco de dados");
            } finally {
                connection.Close();
            }
            return null;
        }

        /// <summary>
        /// Procura um funcionario no ID selecionado
        /// </summary>
        /// <param name="id">ID do funcionario a ser procurado</param>
        /// <returns>Todas as informações de um funcionario</returns>
        public Funcionario Consultar(long id) {
            try {
                //abrir uma conexão com o banco de dados
                connection.Open();

                //  Criar um comando sql na conexão connection
                SqlCommand cmd = new SqlCommand("EXEC VerFuncionario @ID", connection);

                //adciona parametros no comando sql
                cmd.Parameters.AddWithValue("@ID", id);

                //leitor sql (recebe os dados do banco de dados)
                //que esta sendo executado pelo cmd
                SqlDataReader leitor = cmd.ExecuteReader();

                //enquanto tiver dados para ler 
                while (leitor.Read()) {
                    //se tem alguma linha que contenha a coluna cpf 
                    //retorna o funcionario criado
                    return new Funcionario(
                        id: (long)leitor["REGISTRO_FUNCIONARIO"],
                        idPessoa: (long)leitor["ID_FUNCIONARIO"],
                        nome: leitor["NOME_FUNCIONARIO"].ToString(),
                        cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                        rg: leitor["RG_FUNCIONARIO"].ToString(),
                        email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                        telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                        dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                        funcao: new Funcao(
                            ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                            Descricao: leitor["DESCRICAO"].ToString(),
                            CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                            cargo: new Cargo(
                                ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                Nome: leitor["CARGO"].ToString()
                            )
                        ),
                        salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                        situacao: (EnSituacaoFuncionario)Convert.ToInt32(leitor["SITUACAO_FUNCIONARIO"])
                    );

                }
            } catch (SqlException) {
                throw new Exception("Erro ao se conectar no banco de dados");
            } finally {
                connection.Close();
            }
            return null;
        }

        /// <summary>
        /// Retorna todos os funcionarios de um determinado cargo
        /// </summary>
        /// <param name="cargo">Cargo que todos os funcionarios deverão ter em comum</param>
        /// <returns>Todos os funcionarios que tiverem um determinado cargo</returns>
        public List<Funcionario> Consultar(Cargo cargo) {
            //cria uma lista pra armazenar as variaveis
            List<Funcionario> funcs = new List<Funcionario>();

            //tenta
            try {
                //abrir a conexão com o banco
                connection.Open();

                //comando sql
                SqlCommand cmd = new SqlCommand("EXEC VerFuncionariosCargo @CARGO", connection);

                //cria um leitor de dados
                SqlDataReader leitor = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@CARGO",cargo.ID);

                //enquanto o leitor tiver dados para ler
                while (leitor.Read()) {
                    //cria um novo objeto do tipo funcionario
                    Funcionario f = new Funcionario(
                            id: (long)leitor["REGISTRO_FUNCIONARIO"],
                            idPessoa: (long)leitor["ID_FUNCIONARIO"],
                            nome: leitor["NOME_FUNCIONARIO"].ToString(),
                            cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                            rg: leitor["RG_FUNCIONARIO"].ToString(),
                            email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                            telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                            dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                            funcao: new Funcao(
                                ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                                Descricao: leitor["DESCRICAO"].ToString(),
                                CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                                cargo: new Cargo(
                                    ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                    Nome: leitor["CARGO"].ToString()
                                )
                            ),
                            salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                            situacao: (EnSituacaoFuncionario)Convert.ToInt32(leitor["SITUACAO_FUNCIONARIO"])
                        );
                    //adiciona funcionario lista de funcionarios
                    funcs.Add(f);
                }
            } catch (SqlException ex) {
                throw ex;
            } finally {
                connection.Close();
            }
            return funcs;
        }

        /// <summary>
        /// Procura todos os funcionarios que tenham o salario entre 2 valores inseridos por parametros
        /// </summary>
        /// <param name="salarioMin">Menor salario que será procurado</param>
        /// <param name="salarioMax">Maior salario que será procurado</param>
        /// <returns>Uma lista com todos os funcionarios</returns>
        public List<Funcionario> Consultar(double salarioMin, double salarioMax) {
            //cria uma lista pra armazenar as variaveis
            List<Funcionario> funcs = new List<Funcionario>();

            //tenta
            try {
                //abrir a conexão com o banco
                connection.Open();

                //comando sql
                SqlCommand cmd = new SqlCommand("EXEC VerFuncionarioSalario @SALARIO_MIN , @SALARIO_MAX ", connection);

                //cria um leitor de dados
                SqlDataReader leitor = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@SALARIO_MIN", salarioMin);
                cmd.Parameters.AddWithValue("@SALARIO_MAX", salarioMax);
              
                //enquanto o leitor tiver dados para ler
                while (leitor.Read()) {
                    //cria um novo objeto do tipo funcionario
                    Funcionario f = new Funcionario(
                            id: (long)leitor["REGISTRO_FUNCIONARIO"],
                            idPessoa: (long)leitor["ID_FUNCIONARIO"],
                            nome: leitor["NOME_FUNCIONARIO"].ToString(),
                            cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                            rg: leitor["RG_FUNCIONARIO"].ToString(),
                            email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                            telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                            dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                            funcao: new Funcao(
                                ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                                Descricao: leitor["DESCRICAO"].ToString(),
                                CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                                cargo: new Cargo(
                                    ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                    Nome: leitor["CARGO"].ToString()
                                )
                            ),
                            salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                            situacao: (EnSituacaoFuncionario)Convert.ToInt32(leitor["SITUACAO_FUNCIONARIO"])
                        );
                    //adiciona funcionario lista de funcionarios
                    funcs.Add(f);
                }
            } catch (SqlException ex) {
                throw ex;
            } finally {
                connection.Close();
            }
            return funcs;
        }

        public void Excluir(long ID) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cria ou Edita um funcionario (Dependendo do ID)
        /// </summary>
        /// <param name="fun">Funcionario a ser Criado/Editado</param>
        public void Salvar(Funcionario fun) {
            string comando = "";

            if (fun.ID != 0) {
                //atualiza se não for igual a 0
                comando = "UPDATE Funcionario SET Nome=@Nome,Cpf=@Cpf,Rg=@Rg,Email=@Email,Telefone=@Telefone WHERE IDFuncionario = @ID";
            } else {
                //cria for igual a 0 
                //seta a string como um comando de sql
                comando = "EXEC InserirFuncionario @Nome,@DataNascimento,@Cpf,@Rg,@Telefone,@IdFuncao,@Email,@Salario,@Situacao";
            }

            try {
                //abre uma conexão com o banco de dados
                connection.Open();
                //cria comando sql
                SqlCommand cmd = new SqlCommand(comando, connection);
                //ATRIBUI VALORES A STRING SQL
                cmd.Parameters.AddWithValue("@ID", fun.ID);
                cmd.Parameters.AddWithValue("@Nome", fun.Nome);
                cmd.Parameters.AddWithValue("@DataNascimento", fun.DataNascimento);
                cmd.Parameters.AddWithValue("@Cpf", fun.Cpf);
                cmd.Parameters.AddWithValue("@Rg", fun.Rg);
                cmd.Parameters.AddWithValue("@IdFuncao", fun.Funcao_);
                cmd.Parameters.AddWithValue("@Email", fun.Email);
                cmd.Parameters.AddWithValue("@Telefone", fun.Telefone);
                cmd.Parameters.AddWithValue("@Situacao", fun.Situacao);
                //EXECUTA O COMANDO SQL
                cmd.ExecuteNonQuery();
            } catch (SqlException e) {
                throw new Exception("Erro Ao Salvar Funcionario\n" + e.Message);
            } finally {
                connection.Close();
            }
        }
    }
}
