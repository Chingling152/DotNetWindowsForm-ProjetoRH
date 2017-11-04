using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto.Senai.Projetos.Dao {
    class ConectionFactory {
        //Metodo De Conexão Com Banco De Dados

        public SqlConnection GetConnection(){
            //string de conexão com banco de dados
            // ./ = esse computador (então parece melhor usar o ip do computador onde tem o banco de dados)
            string servidor = @"Data Source = .\SQLEXPRESS; Initial Catalog=Empresa;Integrated Security = true;Pooling = false ";

            SqlConnection connection = new SqlConnection(servidor);

            return connection;

        }

    }
}
