using System.Data.SqlClient;

namespace Projeto.Dao {
    /// <summary>
    /// Classe com o unico objetivo de estabelecer conexão com banco de dados
    /// </summary>
    class ConnectionFactory {
        /// <summary>
        /// Metodo de conexão com banco de dados
        /// </summary>
        /// <returns>Retorna uma conexão com o banco de dados</returns>
        public SqlConnection GetConnection(){
            //string de conexão com banco de dados
            // ./ = esse computador (então parece melhor usar o ip do computador onde tem o banco de dados)
            string servidor = @"Data Source = .\SQLEXPRESS; Initial Catalog=Projeto_RH;Integrated Security = true;Pooling = false ";

            SqlConnection connection = new SqlConnection(servidor);

            return connection;
        }

    }
}
