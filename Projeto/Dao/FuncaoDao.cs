using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Projeto.Interfaces;
using Projeto.Modelos;

namespace Projeto.Dao {
    class FuncaoDao : IDao<Funcao> {
        private readonly SqlConnection connection;

        public FuncaoDao() {
            this.connection = new ConnectionFactory().GetConnection();
        }

        public List<Funcao> Consultar() {
            List<Funcao> funcoes = new List<Funcao>();

            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasFuncoes", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    funcoes.Add(
                        new Funcao(
                           ID: Convert.ToInt64(leitor["ID"]),
                           Descricao: leitor["DESCRICAO"].ToString(),
                           CargaHoraria: TimeSpan.Parse(leitor["CARGAHORARIA"].ToString()),
                           IDCargo : Convert.ToInt64(leitor["IDCARGO"])
                        )
                    );
                }
            } finally {
                connection.Close();
            }
            return funcoes;
        }

        public Funcao Consultar(long id) {

            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasFuncoes", connection);

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    return 
                        new Funcao(
                           ID: Convert.ToInt64(leitor["ID"]),
                           Descricao: leitor["DESCRICAO"].ToString(),
                           CargaHoraria: TimeSpan.Parse(leitor["CARGAHORARIA"].ToString()),
                           IDCargo: Convert.ToInt64(leitor["IDCARGO"])
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
