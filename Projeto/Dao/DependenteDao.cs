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

        //construtor
        public DependenteDao() {
            connection = new ConnectionFactory().GetConnection();
        }

        public List<Dependente> Consultar() {
            List<Dependente> dependentes = new List<Dependente>();
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand("EXEC VerTodosDependentes", connection);
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    dependentes.Add(
                      new Dependente( 
                          ID: Convert.ToInt64(leitor["ID_DEPENDENTE"]),
                          IDPessoa: Convert.ToInt64(leitor["REGISTRO_DEPENDENTE"]),
                          Nome: leitor["NOME_DEPENDENTE"].ToString(),
                          Cpf: leitor["CPF_DEPENDENTE"].ToString(),
                          Rg: leitor["RG_DEPENDENTE"].ToString(),
                          Telefone: leitor["TELEFONE_DEPENDENTE"].ToString(),
                          DataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_DEPENDENTE"]),
                          Funcionario_: new Funcionario(
                             id: Convert.ToInt64(leitor["ID_FUNCIONARIO"]),
                             idPessoa: Convert.ToInt64(leitor["REGISTRO_FUNCIONARIO"]),
                             email:leitor["EMAIL_FUNCIONARIO"].ToString(),
                             nome: leitor["NOME_FUNCIONARIO"].ToString(),
                             cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                             rg: leitor["RG_FUNCIONARIO"].ToString(),
                             telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                             dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                             salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                             funcao: new Funcao(
                               ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                               Descricao: leitor["DESCRICAO"].ToString(),
                               CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                               cargo: new Cargo(
                                    ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                    Nome: leitor["CARGO"].ToString()
                               )
                            )
                          )
                      ) 
                    );
                }

            } finally {
                connection.Close();
            }
            return dependentes;
        }

        public Dependente Consultar(long id) {
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand("EXEC VerDependente @ID", connection);
                comando.Parameters.AddWithValue("@ID",id);
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    return
                      new Dependente(
                          ID: Convert.ToInt64(leitor["ID_DEPENDENTE"]),
                          IDPessoa: Convert.ToInt64(leitor["REGISTRO_DEPENDENTE"]),
                          Nome: leitor["NOME_DEPENDENTE"].ToString(),
                          Cpf: leitor["CPF_DEPENDENTE"].ToString(),
                          Rg: leitor["RG_DEPENDENTE"].ToString(),
                          Telefone: leitor["TELEFONE_DEPENDENTE"].ToString(),
                          DataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_DEPENDENTE"]),
                          Funcionario_: new Funcionario(
                             id: Convert.ToInt64(leitor["ID_FUNCIONARIO"]),
                             idPessoa: Convert.ToInt64(leitor["REGISTRO_FUNCIONARIO"]),
                             email: leitor["EMAIL_FUNCIONARIO"].ToString(),
                             nome: leitor["NOME_FUNCIONARIO"].ToString(),
                             cpf: leitor["CPF_FUNCIONARIO"].ToString(),
                             rg: leitor["RG_FUNCIONARIO"].ToString(),
                             telefone: leitor["TELEFONE_FUNCIONARIO"].ToString(),
                             dataNascimento: Convert.ToDateTime(leitor["DATA_NASCIMENTO_FUNCIONARIO"]),
                             salario: Convert.ToDouble(leitor["SALARIO_FUNCIONARIO"]),
                             funcao: new Funcao(
                               ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                               Descricao: leitor["DESCRICAO"].ToString(),
                               CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                               cargo: new Cargo(
                                    ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                    Nome: leitor["CARGO"].ToString()
                               )
                            )
                          )
                      );
                }

            } finally {
                connection.Close();
            }
            return null;
        }

        public void Excluir(long id) {
            
        }

        public void Salvar(Dependente dependente) {
            

        }

        public List<Dependente> VerDependentes(long IDFuncionario) {
            throw new NotImplementedException();
        }
    }
}
