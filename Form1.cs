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
    public partial class Form1 : Form
    {
        public Form _objcadastro = new Form();
        public Form _objdeletar = new Form();
        public Form _objbuscar = new Form();
        public Form _objatualizar = new Form();
        public Form _objprincipal = new Form();
        public Form1()
        {
            InitializeComponent();
            //Deixando o painel "invisivel"
            p_Principal.Visible = false;

            //Sempre que tiver na tela principal o botão voltar some.
            btnVoltar.Visible = false;

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            //Esses são os telas que o botão Voltar irá aparecer.
            if (_objcadastro.Visible == true)
            {
                btnVoltar.Visible = true;
            }
            if (_objbuscar.Visible == true)
            {
                btnVoltar.Visible = true;
            }
            if (_objatualizar.Visible == true)
            {
                btnVoltar.Visible = true;
            }
            if (_objdeletar.Visible == true)
            {
                btnVoltar.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Chamando o form cadastro no painel principal
            _objcadastro?.Close();
            _objcadastro = new Cadastrar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_Principal.Controls.Add(_objcadastro);
            _objcadastro.Show();
            p_Principal.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Chamando o form atualizar no painel principal
            _objatualizar?.Close();
            _objatualizar = new Atualizar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_Principal.Controls.Add(_objatualizar);
            _objatualizar.Show();
            p_Principal.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Chamando o form deletar no painel principal
            _objdeletar?.Close();
            _objdeletar = new Deletar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_Principal.Controls.Add(_objdeletar);
            _objdeletar.Show();
            p_Principal.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //voltando para o painel principal
            _objcadastro.Close();
            _objdeletar.Close();
            _objbuscar.Close();
            _objatualizar.Close();
            _objprincipal = new Form1
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            p_Principal.Controls.Add(_objprincipal);
            p_Principal.Visible = false;

            if (_objprincipal.Visible == false)
            {
                btnVoltar.Visible = false;
            }

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            //Chamando o form buscar no painel principal
            _objbuscar?.Close();
            _objbuscar = new Buscar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_Principal.Controls.Add(_objbuscar);
            _objbuscar.Show();
            p_Principal.Visible = true;
        }
    }
}
