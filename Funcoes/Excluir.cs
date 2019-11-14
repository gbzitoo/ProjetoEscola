using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public class Excluir
    {
        //Consulta sql para deletar pelo id 
        public string ConsultaExcluir = "delete from Aluno where id=@id";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;

        public void Deletar(int id)
        {
            //conexão
            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            // recebendo consulta e conexão
            MySqlCommand conn = new MySqlCommand(ConsultaExcluir, sqlcon);

            //id digitado pelo usuario no textfield.
            conn.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            try
            {
                sqlcon.Open();
                MySqlDataReader dr = conn.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Aluno excluido");
                }

                dr.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                sqlcon.Close();

            }

        }
    }
}
