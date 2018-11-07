using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Go.DAO;
using Go.BO;
using Go.MODEL;


namespace Go.VIEW
{
    public partial class TelaConfidencializaProjeto : Form
    {


        public TelaConfidencializaProjeto()
        {
            InitializeComponent();
        }
        public TelaConfidencializaProjeto(Projeto proj) 
        {
            InitializeComponent();
            this.proj = proj;    
        }


        DAOProjeto daoProj = new DAOProjeto();
        BOProjeto boProj = new BOProjeto();
        Projeto proj = null;
        string senha;

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

            senha = txtSenha.Text;
            proj._Lembrete = txtLembrete.Text;

            if (txtLembrete.Text == "")
                proj._Lembrete = "";

            if (txtSenha.Text == txtRepeteSenha.Text)
            {
                proj._Senha = senha;
                boProj.BOInsereSenha(proj);
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não correspondem! Arruma isso colega!");
            }
        }

        private void ConfidencializaProjeto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}