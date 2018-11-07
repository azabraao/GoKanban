using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Go.VIEW;
using Go.MODEL;

namespace Go
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public Login(Projeto proj)
        {
            InitializeComponent();
        }
        public Login(Conf conf)
        {
            InitializeComponent();
            this.conf = conf;
        }


        Conf conf = null;

        private void button1_Click(object sender, EventArgs e)
        {
            TelaProjeto tela = new TelaProjeto();
            if (txtSenha.Text == conf._Senha)
            {
                tela.Show();

                this.Hide();
            }
            else
                MessageBox.Show("Senha e/ou usuário incorretos! ");

        }

    }
}
