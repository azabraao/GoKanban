using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Go.MODEL;
using Go.BO;

namespace Go.VIEW
{
    public partial class TelaConfigProjeto : Form
    {
        private TelaProjeto telaProjetos;
        TelaProjeto tela = null;
        BOProjeto boProjeto = new BOProjeto();
        Tarefa tarefa = null;
        Projeto proj = new Projeto();


        public TelaConfigProjeto()
        {
            InitializeComponent();


        }
        public TelaConfigProjeto(Projeto proj, Tarefa tarefa, TelaProjeto tela)
        {
            InitializeComponent();
            this.proj = proj;
            this.tarefa = tarefa;
            this.tela = tela;
        }

        public TelaConfigProjeto(TelaProjeto telaProjetos)
        {
            this.telaProjetos = telaProjetos;
        }


        

        private void telaUsuario_Load(object sender, EventArgs e)
        {
            txtDescricao.Text = proj._Descricao;
            lblTitulo.Text = proj._Titulo;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (proj._Senha != "Tn3rD({)P")
            {
                MessageBox.Show("Projeto já bloqueado");
            }
            else
            {
                TelaConfidencializaProjeto tela = new TelaConfidencializaProjeto(proj);
                tela.Show();
            }
        }

        private void btnDesconfidencializar_Click(object sender, EventArgs e)
        {
          //  proj._Senha = "Tn3rD({)P";
          // boProjeto.BOInsereSenha(proj);

            TelaDesconfidencialiacao desc = new TelaDesconfidencialiacao(proj);

            desc.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorioProjeto rel = new TelaRelatorioProjeto(tarefa);
            rel.Show();
        }

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            txtTitulo.Visible = true;

        }

        private void OnEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblTitulo.Text = txtTitulo.Text;
                txtTitulo.Visible = false;
                proj._Titulo = lblTitulo.Text;
                boProjeto.BOAtualizaTitulo(proj);

                tela.limpaComboBox();
                tela.CarregaComboBox();
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            string cor = "DarkSalmon";
            boProjeto.BOAtualizaCor(cor, proj._Id);
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            string cor = "YellowGreen";
            boProjeto.BOAtualizaCor(cor, proj._Id);
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {

            string cor = "SteelBlue";
            boProjeto.BOAtualizaCor(cor, proj._Id);
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            string cor = "LightGreen";
            boProjeto.BOAtualizaCor(cor, proj._Id);
           // tela.atualizaTopo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            proj._Status = 0;
            boProjeto.BODeletaProjeto(proj);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "" && txtTitulo.Text != proj._Titulo)
                proj._Titulo = txtTitulo.Text;

            proj._Descricao = txtDescricao.Text;

            BOProjeto boNovoProjeto = new BOProjeto();

            boNovoProjeto.BOAtualizaProjeto(proj);

            tela.limpaComboBox();
            this.Close();
        }


    }
}
