using System.Data.SqlClient;

namespace Projeto.Dao {
    class ConectionFactory {
        //Metodo De Conexão Com Banco De Dados

        public SqlConnection GetConnection(){
            //string de conexão com banco de dados
            // ./ = esse computador (então parece melhor usar o ip do computador onde tem o banco de dados)
            string servidor = @"Data Source = .\SQLEXPRESS; Initial Catalog=Projeto_RH;Integrated Security = true;Pooling = false ";

            SqlConnection connection = new SqlConnection(servidor);

            return connection;

        }

    }
}
