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
    public partial class TelaNovoProjeto : Form
    {
        public TelaNovoProjeto()
        {
            InitializeComponent();

        }

        BOProjeto boNovoProjeto = new BOProjeto();
        Projeto proj = new Projeto();

        public TelaNovoProjeto(TelaProjeto tela)
        {
            InitializeComponent();
            this.tela = tela;
        }

        TelaProjeto tela = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

        }

        private void btnGeraProjeto_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Coloca um título ai, gente boa! Nosso banco agradece!");
            }
            else
            {
                proj._Titulo = txtTitulo.Text;
                proj._Descricao = txtDescricao.Text;

                boNovoProjeto.BOInserirProjeto(proj);

                this.Close();
                TelaProjeto t = new TelaProjeto();
                t.CarregaComboBox();
                //this.tela.limpaComboBox();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
 
        }

        public Control pnlConfig { get; set; }

        private void frmNovoProjeto_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string DataInicio = dtpInicio.Text;


            DateTime data = Convert.ToDateTime(DataInicio);

            proj._Inicio = data;

            boNovoProjeto.BOInsereInicio(proj);
        }

        private void dtpFim_ValueChanged_1(object sender, EventArgs e)
        {
            string DataInicio = dtpInicio.Text;

            DateTime data = Convert.ToDateTime(DataInicio);

            proj._Fim = data;

            boNovoProjeto.BOInsereFim(proj);
        }
    }


}

