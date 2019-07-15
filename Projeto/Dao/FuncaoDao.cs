using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Projeto.Interfaces;
using Projeto.Modelos;

namespace Projeto.Dao {
    /// <summary>
    /// Classe que lida com dados referentes a função de Funcionarios
    /// </summary>
    class FuncaoDao : IDao<Funcao> {
        private readonly SqlConnection connection;

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public FuncaoDao() {
            this.connection = ConnectionFactory.GetConnection();
        }

        /// <summary>
        /// Procura todas as funções cadastradas no banco de dados
        /// </summary>
        /// <returns>Uma lista com todas as funções cadastradas</returns>
        public List<Funcao> Consultar() {
            List<Funcao> funcoes = new List<Funcao>();

            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasFuncoes", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    funcoes.Add(
                        new Funcao(
                           ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                           Descricao: leitor["DESCRICAO"].ToString(),
                           CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                           cargo: new Cargo(
                                ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                Nome: leitor["CARGO"].ToString()
                           )
                        )
                    );
                }
            } finally {
                connection.Close();
            }
            return funcoes;
        }

        /// <summary>
        /// Procura uma função no ID selecionado
        /// </summary>
        /// <param name="id">ID da função a ser procurada</param>
        /// <returns>Uma função caso ela exista, senão retorna null</returns>
        public Funcao Consultar(long id) {

            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasFuncoes", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    return 
                        new Funcao(
                            ID: Convert.ToInt64(leitor["ID_FUNCAO"]),
                            Descricao: leitor["DESCRICAO"].ToString(),
                            CargaHoraria: TimeSpan.Parse(leitor["CARGA_HORARIA"].ToString()),
                            cargo: new Cargo(
                                ID: Convert.ToInt64(leitor["ID_CARGO"]),
                                Nome: leitor["CARGO"].ToString()
                           )
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

        public void Salvar(Funcao item) {
            throw new System.NotImplementedException();
        }
    }
}
