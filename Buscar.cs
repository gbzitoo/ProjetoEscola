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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procurar p = new Procurar();
            //Essa função ira buscar o aluno pelo id que você passar no txtfield
            if (txBuscandoId.Text == String.Empty || int.Parse(txBuscandoId.Text) == 0)
            {
                MessageBox.Show("Você precisa me informar um ID valido!");
            }
            else { p.Buscando(int.Parse(txBuscandoId.Text)); }
            

            //aqui ele ira escrever no textfield o que ele recebeu do Nome que a função buscar puxou do banco de dados.
            txBuscaNome.Text = p.Nome;

            // aqui eu estou pegando o valor e funçando ele a virar string (a função retorna ele em int) e depois jogando no txtfield
            var recebeNacimento = Convert.ToString(p.Nascimento);
            txBuscaNascimento.Text = recebeNacimento;
            //aqui a mesma coisa que em cima.
            var recebeAno = Convert.ToString(p.Ano);
            txBuscaAno.Text = recebeAno;

        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }
    }
}
