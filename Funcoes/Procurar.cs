using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public class Procurar
    {
        public String Nome = "";
        public int Nascimento = 0;
        public int Ano = 0;
        public string ConsultaProcurar = "SELECT nome, nascimento, ano FROM Aluno WHERE id=@id";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();

        public void Buscando(int id)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(ConsultaProcurar, sqlcon);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


            try
            {
                //Verifica se o campo está vazio.
                if (Convert.ToString(id) == string.Empty)
                {
                    MessageBox.Show("Você precisa por um Codigo!");
                }


                sqlcon.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                //Verifica se tem o id passado na tabela.
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Codigo não cadastrado!");
                }


                dr.Read();

                Nome = Convert.ToString(dr["Nome"]);
                Nascimento = Convert.ToInt32(dr["Nascimento"]);
                Ano = Convert.ToInt32(dr["Ano"]);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!");
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
