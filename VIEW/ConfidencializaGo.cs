using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Go.VIEW
{
    public partial class ConfidencializaGo : Form
    {
        public ConfidencializaGo()
        {
            InitializeComponent();
            conf._Booleano = true;
        }

        MODEL.Conf conf = new MODEL.Conf();
        BO.BOUsuario boUser = new BO.BOUsuario();

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            
            conf._Senha = txtSenha.Text;

            boUser.BOInsertUsuario(conf);
        }

        private void telaCadastroUsuario_Load(object sender, EventArgs e)
        {
            //txtUsuario.Hide();
            //label1.Hide();
            
        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        } 
    }
}
