using Projeto.Interfaces;
using Projeto.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto.Dao {
    class PessoaDao : IDao<Pessoa>, IPessoa {
        /// <summary>
        /// Arquivo de conexão com o banco de dados
        /// </summary>
        private SqlConnection connection;

        public PessoaDao() {
            connection = new ConnectionFactory().GetConnection();
        }

        /// <summary>
        /// Procura um registro de uma pessoa com o CPF selecionado
        /// </summary>
        /// <param name="cpf">CPF da pessoa a ser procurado</param>
        /// <returns>Uma pessoa com o CPF selecionado ou null caso ela não exista</returns>
        public Pessoa Consultar(string cpf) {
            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerRegistroPorCpf @CPF", connection);
                comando.Parameters.AddWithValue("@CPF", cpf);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    return
                        new Pessoa(
                           IDPessoa: Convert.ToInt64(leitor["ID"]),
                           Nome: leitor["Nome"].ToString(),
                           Cpf: leitor["CPF"].ToString(),
                           Rg: leitor["RG"].ToString(),
                           Telefone: leitor["TELEFONE"].ToString(),
                           DataNascimento: Convert.ToDateTime(leitor["DATANASCIMENTO"]),
                           Funcionario: Convert.ToBoolean(leitor["FUNCIONARIO"])
                       );
                }
            } finally {
                connection.Close();
            }
            return null;
        }

        /// <summary>
        /// Lista todos os registros do banco de dados
        /// </summary>
        /// <returns>Registros de todas as pessoas cadastradas</returns>
        public List<Pessoa> Consultar() {
            List<Pessoa> pessoas = new List<Pessoa>();

            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodosRegistros", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    pessoas.Add(
                        new Pessoa(
                           IDPessoa: Convert.ToInt64(leitor["ID"]),
                           Nome: leitor["Nome"].ToString(),
                           Cpf: leitor["CPF"].ToString(),
                           Rg: leitor["RG"].ToString(),
                           Telefone: leitor["TELEFONE"].ToString(),
                           DataNascimento: Convert.ToDateTime(leitor["DATANASCIMENTO"]),
                           Funcionario: Convert.ToBoolean(leitor["FUNCIONARIO"])
                        )
                    );
                }
            } finally {
                connection.Close();
            }
            return pessoas;
        }

        /// <summary>
        /// Procura um registro de uma pessoa com o ID selecionado no banco de dados
        /// </summary>
        /// <param name="id">ID da pessoa a ser procurada</param>
        /// <returns>Uma pessoa com o ID selecionado ou null caso ela não exista</returns>
        public Pessoa Consultar(long id) {
            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerRegistro @ID", connection);
                comando.Parameters.AddWithValue("@ID",id);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    return 
                        new Pessoa(
                           IDPessoa: Convert.ToInt64(leitor["ID"]),
                           Nome: leitor["Nome"].ToString(),
                           Cpf: leitor["CPF"].ToString(),
                           Rg: leitor["RG"].ToString(),
                           Telefone: leitor["TELEFONE"].ToString(),
                           DataNascimento: Convert.ToDateTime(leitor["DATANASCIMENTO"]),
                           Funcionario: Convert.ToBoolean(leitor["FUNCIONARIO"])
                       );
                }
            } finally {
                connection.Close();
            }
            return null;
        }

        public void Excluir(long id) {
            throw new System.NotImplementedException();
        }

        public void Salvar(Pessoa item) {
            throw new System.NotImplementedException();
        }
    }
}
