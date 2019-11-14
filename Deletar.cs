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
    public partial class Deletar : Form
    {
        public Deletar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            //essa função pega o id que o usuario digito e deleta.
            excluir.Deletar(int.Parse(textBox1.Text));
        }
    }
}
