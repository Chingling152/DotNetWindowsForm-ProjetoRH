using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Projeto.Interfaces;
using Projeto.Modelos;

namespace Projeto.Dao {
    /// <summary>
    /// Classe que lida com dados referente a tipos de dependencia entre dependentes e funcionarios
    /// </summary>
    class TipoDependenciaDao : IDao<TipoDependencia> {
        /// <summary>
        /// Arquivo de conexão com o banco de dados
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Construtor da classe TipoDependenciaDao , Inicia uma conexão com o banco de dados 
        /// </summary>
        public TipoDependenciaDao() {
            connection = ConnectionFactory.GetConnection();
        }

        /// <summary>
        /// Procura todos os tipos de dependencias do banco de dados
        /// </summary>
        /// <returns>Uma lista com todos os tipos de dependencias</returns>
        public List<TipoDependencia> Consultar() {
            List<TipoDependencia> tipoDependencias = new List<TipoDependencia>();
            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasDependencias", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.HasRows) {
                    while (leitor.Read()) {
                        tipoDependencias.Add(
                            new TipoDependencia(
                              id: Convert.ToInt64(leitor["ID"]),
                              tipoDependencia: leitor["NOME"].ToString()
                            )
                        );
                    }
                }

            } finally {
                connection.Close();
            }
            return tipoDependencias;

        }

        /// <summary>
        /// Procura um tipo de dependencia no ID selecionado
        /// </summary>
        /// <param name="id">ID do tipo de dependencia</param>
        /// <returns>Retorna um tipo de dependencia ou null caso ele não exista</returns>
        public TipoDependencia Consultar(long id) {
            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerDependencia @ID", connection);
                comando.Parameters.AddWithValue("@ID",id);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.HasRows) {
                    while (leitor.Read()) {
                        return new TipoDependencia(
                              id: Convert.ToInt64(leitor["ID"]),
                              tipoDependencia: leitor["NOME"].ToString()
                            );
                    }
                }

            } finally {
                connection.Close();
            }
            return null;

        }

        public void Excluir(long id) {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Cria ou edita um registro de Tipo de dependencia no banco de dados
        /// </summary>
        /// <param name="item">Tipo de dependencia a ser inserida/editada</param>
        public void Salvar(TipoDependencia item) {
            string comando = "";
            if (item.id!= 0) {

            } else {
                comando = "EXEC InserirDependencia @NOME";
            }

            try {
                //abre uma conexão com o banco de dados
                connection.Open();
                //cria comando sql
                SqlCommand cmd = new SqlCommand(comando, connection);
                //ATRIBUI VALORES A STRING SQL
                cmd.Parameters.AddWithValue("@NOME", item.id);
                //EXECUTA O COMANDO SQL
                cmd.ExecuteNonQuery();
            } catch (SqlException e) {
                throw new Exception("Erro Ao Salvar Dependencia\n" + e.Message);
            } finally {
                connection.Close();
            }
        }
    }
}
