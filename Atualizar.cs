using System;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }
        public Alterar a = new Alterar();
        Procurar p = new Procurar();
        private void Button2_Click(object sender, EventArgs e)
        {
            //Essa função ira buscar o aluno pelo id que você passar no txtfield
            //a função Buscando é herdada da classe Procurar
            p.Buscando(int.Parse(txId.Text));
            //aqui ele ira escrever no textfield o que ele recebeu do Nome que a função buscar puxou do banco de dados.
            txNome.Text = p.Nome;
            // aqui eu estou pegando o valor e funçando ele a virar string (a função retorna ele em int) e depois jogando no txtfield
            var recebeNacimento = Convert.ToString(p.Nascimento);
            txNascimento.Text = recebeNacimento;
            //aqui a mesma coisa que em cima.
            var recebeAno = Convert.ToString(p.Ano);
            txAno.Text = recebeAno;


        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //------------------------------------Atualizando--------------------------------------------
            //pegando os valores que a função Buscando botou no txtfield, alterando e quando esse novo valor em uma variavel.
            var IDDigitadoParaPesquisa = txId.Text;
            var PegandoNome = txNome.Text;
            var PegandoNascimento = txNascimento.Text;
            var pegandoAno = txAno.Text;

            //botando o novo valor do textfield no banco com alter table.
            a.Alterando(int.Parse(IDDigitadoParaPesquisa), PegandoNome, int.Parse(PegandoNascimento), int.Parse(pegandoAno));
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
