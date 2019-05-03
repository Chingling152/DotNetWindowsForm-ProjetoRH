using Interfaces;
using Projeto.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto.Dao {
    class TipoDependenciaDao : IDao<TipoDependencia> {
        /// <summary>
        /// Arquivo de conexão com o banco de dados
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Mensagem de feedback 
        /// </summary>
        private string msg = null;

        /// <summary>
        /// Titulo
        /// </summary>
        private string titulo = null;

        //constructor
        public TipoDependenciaDao() {
            connection = new ConectionFactory().GetConnection();
        }

        public List<TipoDependencia> Consultar() {
            List<TipoDependencia> tipoDependencias = new List<TipoDependencia>();
            try {
                connection.Open();

                SqlCommand comando = new SqlCommand("EXEC VerTodasDependencias",connection);
                
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

        public TipoDependencia Consultar(long id) {
            throw new System.NotImplementedException();
        }

        public void Excluir(long id) {
            throw new System.NotImplementedException();
        }

        public void Salvar(TipoDependencia item) {
            throw new System.NotImplementedException();
        }
    }
}
