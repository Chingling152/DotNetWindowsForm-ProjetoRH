using System.Collections.Generic;
using Projeto.Senai.Projetos.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto.Dao {
    class DependenciaDao : IDao<Dependencia> {
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
        public DependenciaDao() {
            connection = new ConectionFactory().GetConnection();
        }

        //MESMA MERDA DO FuncDao
        public List<Dependencia> Consultar() {
            sql = "SELECT * FROM Dependencia";

            List<Dependencia> depe = new List<Dependencia>();

            try{
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql,connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read()){
                    Dependencia dep= new Dependencia(){
                        ID = (long) reader["IDDependencia"],
                        Descricao = reader["Descricao"].ToString()
                    };

                    depe.Add(dep);                   
                }
            }
            catch(SqlException ex){
                msg = "Erro Ao Consultar Dependencias Cadastradas \n" + ex.Message;
                titulo = "Erro...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{
                connection.Close();
            }
            return depe;
        }

        public void Excluir(Dependencia d) {
            sql = "DELETE FROM Dependencia WHERE IDDependencia = @id";
                
            try{
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql,connection);
                cmd.Parameters.AddWithValue("@id",d.ID);

                cmd.ExecuteNonQuery();

                msg = "Dependencia " + d.Descricao + " Excluida Com Sucesso";
                titulo = "Excluir...";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex){
                msg = "Erro Ao Excluir Dependencia. \n" + ex.Message;
                titulo = "Erro";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally{
                connection.Close();
            }

        }

        public void Salvar(Dependencia dp) {

            if(dp.ID !=0) {
                sql = "UPDATE Dependencia SET Descricao = @desc WHERE IDDependencia = @id";              
            }else{
                sql = "INSERT INTO Dependencia (Descricao) VALUES(@desc) ";
            }

            try{
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql,connection);

                cmd.Parameters.AddWithValue("@id", dp.ID);
                cmd.Parameters.AddWithValue("@desc",dp.Descricao);

                cmd.ExecuteNonQuery();

                msg = "Dependencia " + dp.Descricao + " Salva Com Sucesso";
                titulo = "Sucesso...";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(SqlException ex){
                msg = "Erro Ao Salvar Dependencia \n" + ex.Message;
                titulo = "Erro";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally{
                connection.Close();
            }

        }


    }
}
