using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Senai.Projetos.Forms;
using Projeto.Senai.Projetos.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto.Senai.Projetos.Dao {
    class DepenDao : IDao<Dependencia> {
        //conexão com o banco de dados
        private SqlConnection connection;
        //intrução sql
        private string sql = null;
        //mensagem do messagebox
        private string msg = null;
        //titulo da messagebox
        private string titulo = null;

        //constructor
        public DepenDao() {
            connection = new ConectionFactory().GetConection();
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
                        Id = (long) reader["IDDependencia"],
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
                cmd.Parameters.AddWithValue("@id",d.Id);

                cmd.ExecuteNonQuery();

                msg = "Dependencia " + d.Descricao + " Excluida Com Sucesso";
                titulo = "Excluir...";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex){
                msg = "Erro Ao Excluir Dependencia. \n" + ex;
                titulo = "Erro";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally{
                connection.Close();
            }

        }

        public void Salvar(Dependencia dp) {

            if(dp.Id !=0){
                sql = "INSERT INTO Dependencia (Descricao) VALUES(@desc) ";
            }else{
                sql = "UPDATE FROM Dependencia SET Descricao = @desc";
            }

            try{
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql,connection);

                cmd.Parameters.AddWithValue("@desc",dp.Descricao);

                cmd.ExecuteNonQuery();

                msg = "Dependencia " + dp.Descricao + " Salva Com Sucesso";
                titulo = "Sucesso...";

                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(SqlException ex){
                msg = "Erro Ao Salvar Dependencia";
                titulo = "Erro";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally{
                connection.Close();
            }

        }
    }
}
