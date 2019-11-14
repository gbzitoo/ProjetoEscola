using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public class Inserir 
    {
        public String ConsultaInserir = "INSERT INTO Aluno(id,nome,nascimento,ano) VALUES (@id,@nome,@nascimento,@ano)";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;

        public void Cadastrar(int id, string nome, int nascimento, int ano)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(ConsultaInserir, sqlcon);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value =id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Int32).Value = nascimento;
            comando.Parameters.Add("@ano", MySqlDbType.Int32).Value = ano;

            try
            {
                if (Convert.ToString(id) == string.Empty)
                {
                    throw new Exception("Você precisa por um Codigo!");
                }
                if (nome == string.Empty)
                {
                    throw new Exception("Você precisa por um Nome!");
                }
                if (Convert.ToString(nascimento) == string.Empty)
                {
                    throw new Exception("Você precisa por sua data de nascimento!");
                }
                if (Convert.ToString(ano) == string.Empty)
                {
                    throw new Exception("Você precisa por o ano!");
                }


                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex);
                
            }
            finally
            {

                sqlcon.Close();

            }

        }

    }
}
