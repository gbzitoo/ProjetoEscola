using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class Cadastrar : Form
    {
        
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

           

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();

            //Alocando os dados do input nas variaveis para botar na função
            var ID = int.Parse(txID.Text);
            var Nome = txNome.Text;
            var Nascimento = int.Parse(txNascimento.Text);
            var Ano = int.Parse(txAno.Text);

            //recebendo os dados das variaveis para gravar no banco de dados.
            inserir.Cadastrar(ID,Nome,Nascimento,Ano);
        }
    }
}
