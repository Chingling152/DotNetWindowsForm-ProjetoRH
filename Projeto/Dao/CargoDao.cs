using Interfaces;
using Projeto.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto.Dao {
    class CargoDao : IDao<Cargo> {

        private SqlConnection connection;

        public string titulo { get; private set; } = null;

        public string mensagem { get; private set; } = null;

        public List<Cargo> Consultar() {
            List<Cargo> cargos = new List<Cargo>();

            try {
                connection.Open();
                SqlCommand comando = new SqlCommand("EXEC ",connection);
                SqlDataReader leitor = comando.ExecuteReader();
            } catch (System.Exception) {

                throw;
            }
             return cargos;
        }

        public Cargo Consultar(long id) {
            throw new System.NotImplementedException();
        }

        public void Excluir(long id) {
            throw new System.NotImplementedException();
        }

        public void Salvar(Cargo item) {
            throw new System.NotImplementedException();
        }
    }
}
