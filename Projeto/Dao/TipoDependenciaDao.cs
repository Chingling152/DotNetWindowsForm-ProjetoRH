using Interfaces;
using Projeto.Modelos;
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
        /// String de comando SQL
        /// </summary>
        private string sql = null;

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
            throw new System.NotImplementedException();
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
