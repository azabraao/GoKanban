using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Go.BO;
using Go.MODEL;

namespace Go.VIEW
{
    public partial class TelaDesconfidencialiacao : Form
    {
        public TelaDesconfidencialiacao(Projeto proj)
        {
            InitializeComponent();
            this.proj = proj;
        }

        Projeto proj = null;
        BOProjeto boProjeto = new BOProjeto();

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == proj._Senha)
            {
                MessageBox.Show("Pronto! Projeto desbloqueado.");
                proj._Senha = "Tn3rD({)P";
                boProjeto.BOInsereSenha(proj);
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha errada!");
            }
        }

        private void Desconfidencialiacao_Load(object sender, EventArgs e)
        {
            lblLembrete.Text = "LEMBRETE:  " + proj._Lembrete;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
