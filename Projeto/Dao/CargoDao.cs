using System;
using Projeto.Modelos;
using Projeto.Interfaces;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Projeto.Dao {
    /// <summary>
    /// Classe responsavel por lidar com alteração , cadastro , listagem e exclusão de cargos
    /// </summary>
    class CargoDao : IDao<Cargo> {

        /// <summary>
        /// Variavel responsavel pela conexão da aplicação com o banco de dados
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Construtor da classe CargoDao
        /// </summary>
        public CargoDao() {
            connection = ConnectionFactory.GetConnection();
        }

        /// <summary>
        /// Lista todos os Cargos do banco de dados
        /// </summary>
        /// <returns>Uma lista com todos os cargos do banco de dados</returns>
        public List<Cargo> Consultar() {
            List<Cargo> cargos = new List<Cargo>();

            try {
                connection.Open();
                SqlCommand comando = new SqlCommand("EXEC VerTodosCargos", connection);
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.HasRows) {
                    while (leitor.Read()) {
                        cargos.Add(
                          new Cargo(
                              ID : Convert.ToInt64(leitor["ID"]),
                              Nome: leitor["NOME"].ToString()
                          )
                        );
                    }
                }
            } catch (Exception) {
                throw;
            }finally{
                connection.Close();
            }
             return cargos;
        }

        /// <summary>
        /// Lista um cargo especifico do banco de dados
        /// </summary>
        /// <param name="id">ID do cargo selecionado</param>
        /// <returns>Cargo a ser retornado</returns>
        public Cargo Consultar(long id) {
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand("EXEC VerCargo @ID", connection);
                comando.Parameters.AddWithValue("@ID",id);
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.HasRows) {
                    while (leitor.Read()) {
                        return 
                          new Cargo(
                              ID: Convert.ToInt64(leitor["ID"]),
                              Nome: leitor["NOME"].ToString()
                          );
                    }
                }
            } catch (Exception) {
                throw;
            } finally {
                connection.Close();
            }
            return null;
        }

        public void Excluir(long id) {
            throw new System.NotImplementedException();
        }

        public void Salvar(Cargo item) {
            throw new System.NotImplementedException();
        }
    }
}
