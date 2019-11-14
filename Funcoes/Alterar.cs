using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public class Alterar : Procurar
    {
        public String Nome = "";
        public int Nascimento { get; set; }
        public int Ano { get; set; }

        public string ConsultaAlterar = "UPDATE aluno SET Nome=@nome,nascimento=@nascimento,ano=@ano WHERE id=@id";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        public void Alterando(int id,string nome, int nascimento, int ano)
        {
            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(ConsultaAlterar, sqlcon);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Int32).Value = nascimento;
            comando.Parameters.Add("@ano", MySqlDbType.Int32).Value = ano;
            try
            {

                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);

            }
            finally
            {

                sqlcon.Close();

            }
        }
    }
}
