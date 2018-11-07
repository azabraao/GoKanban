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
    public partial class TelaConfigTarefa : Form 
    {
        
        public TelaConfigTarefa()
        {
            InitializeComponent();
        }

        BO.BOConfigTarefa boConfig = new BOConfigTarefa();
        DAO.DAOConfig daoConfig = new DAO.DAOConfig();
        Tarefa tarefa = null;
        BO.BOTarefa boTarefa = new BOTarefa();
        int seg = 00, min = 00, hr = 00;

        string titulo;
        string descricao;
        int coluna;

        TelaProjeto  tela = null;

        public TelaConfigTarefa(Tarefa tarefa, TelaProjeto tela)
        {
            InitializeComponent();

            txtTitulo.Text = tarefa._Titulo;
            boConfig.selectTarefa(tarefa);
            txtDescricao.Text = tarefa._Descricao;
            this.tarefa = tarefa;
            this.tela = tela;

            this.titulo = tarefa._Titulo;
            this.descricao = tarefa._Descricao;
            this.coluna = tarefa._Coluna;

            //Pegando a data de término da tarefa e colocando no label
            this.lblDataFinal.Text = Convert.ToString(tarefa._Fim.ToShortDateString());


            //Subtraindo o dia que se iniciará com o dia de hoje.
            TimeSpan qtdDiasParaInicio = Convert.ToDateTime(tarefa._Inicio) - DateTime.Now;
            TimeSpan qtdDiasParaFim = Convert.ToDateTime(tarefa._Fim) - DateTime.Now;
            int diasParaInicio = qtdDiasParaInicio.Days;
            int diasParaFim = qtdDiasParaFim.Days;

            if (tarefa._Inicio.ToShortDateString() == "28/08/1991" || tarefa._Fim.ToShortDateString() == "21/08/1995")
            {
                lblQtdDias.Text = "";
                lblDataFinal.Text = "";
            }
            else if (diasParaInicio < 0)
            { 
                lblQtdDias.Text = "Faltam " + diasParaFim + " dias para terminar!";
                if (diasParaFim == 1)
                {
                    boTarefa.BOAtualizaCor("Red", tarefa._Id);
                    tela.limpaColuna01();
                    tela.limpaColuna02();
                    tela.limpaColuna03();
                    tela.AtualizaColunas();
                }
            }
            else
            {
                lblQtdDias.Text = "Faltam " + diasParaInicio + " dias para começar!";

            }
        }




        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            if (txtTitulo.Text == "") {
                MessageBox.Show("Sua tarefa não tem titulo?");
            }
            else if (txtTitulo.Text == titulo)
            {
                tarefa._Descricao = txtDescricao.Text;
                tarefa._Titulo = txtTitulo.Text;

                switch (cmbColuna.GetItemText(cmbColuna.SelectedItem))
                { 
                    case "To Do":
                        tarefa._Coluna = 1;
                        break;
                    case "Doing":
                        tarefa._Coluna = 2;
                        break;
                    case "Done":
                        tarefa._Coluna = 3;
                        break;
                }
                BOTarefa boTarefa = new BOTarefa();

                boTarefa.BOAtualizaTarefa(tarefa._Coluna,tarefa._Id, tarefa._Descricao);

                tela.limpaColuna01();
                tela.limpaColuna02();
                tela.limpaColuna03();

                tela.AtualizaColunas();

                this.Close();
            }
            else
            {
                tarefa._Descricao = txtDescricao.Text;
                tarefa._Titulo = txtTitulo.Text;
                switch (cmbColuna.GetItemText(cmbColuna.SelectedItem))
                {
                    case "To Do":
                        tarefa._Coluna = 1;
                        break;
                    case "Doing":
                        tarefa._Coluna = 2;
                        break;
                    case "Done":
                        tarefa._Coluna = 3;
                        break;
                }

                BOTarefa boTarefa = new BOTarefa();

                boTarefa.BOAtualizaTarefa(tarefa);

                tela.limpaColuna01();
                tela.limpaColuna02();
                tela.limpaColuna03();

                tela.AtualizaColunas();

                this.Dispose();
            } 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tarefa._Coluna = 4;

            boConfig.BODeletaTarefa(tarefa);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();

            tela.AtualizaColunas();


        }
         
        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            string DataInicio = dtpInicio.Text;


            DateTime data = Convert.ToDateTime(DataInicio);


            if (data < DateTime.Now)
            {
                MessageBox.Show("Ei! Uma tarefa não pode começar antes te ontem!");
            }
            else
            {
                tarefa._Inicio = data;

                boTarefa.BOInsereInicio(tarefa);
            }
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            string DataFim = dtpFim.Text;


            DateTime data = Convert.ToDateTime(DataFim);

            if (data < DateTime.Now)
            {
                MessageBox.Show("Ei! Uma tarefa não pode terminar antes te ontem!");
            }
            else if(tarefa._Inicio.ToShortDateString() == "28/08/1991")
            {
                MessageBox.Show("Você ainda não definiu a data de início!");
            }
            else
            {
                tarefa._Fim = data;

                boTarefa.BOInsereFim(tarefa);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DateTime time = Convert.ToDateTime(lblCronometro.Text);
            tarefa._TempoExecucao = time;


            boConfig.BOAtualizaTempo(tarefa);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblCronometro.Text = "00:00:00";

            DateTime time = Convert.ToDateTime(lblCronometro.Text);
            tarefa._TempoExecucao = time;


            boConfig.BOAtualizaTempo(tarefa);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                seg++;

                if (seg == 60)
                {
                    min++;
                    seg = 00;
                }
                else if (min == 60)
                {
                    hr++;
                    min = 00;
                }
            //Isso resolve o bug só por enquanto. Se o usuário levar mais de 12 horas para concuir a tarefa, teremos um problema.
                if (hr == 12)
                    hr = 00;
                lblCronometro.Text = hr.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
            /*
                barraDeProgresso.Minimum = 1;
                barraDeProgresso.Value = 3;
                barraDeProgresso.Maximum = 123;
                barraDeProgresso.Increment(1);
                lblPorcentagem.Text = barraDeProgresso.Value.ToString() + "%";
             */
        }

   #region BOTÕES PARA COLOCAR CORES NAS TAREFAS
        private void btnWhite_Click(object sender, EventArgs e)
        {
            string cor = "White";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnLightGreen_Click_1(object sender, EventArgs e)
        {
            string cor = "LightGreen";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();

        }

        private void btnChartreuse_Click(object sender, EventArgs e)
        {
            string cor = "Chartreuse";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnYellowGreen_Click(object sender, EventArgs e)
        {
            string cor = "YellowGreen";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            string cor = "Orange";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnSalmon_Click(object sender, EventArgs e)
        {
            string cor = "Salmon";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
            
        }

        private void btnDarkSalmon_Click(object sender, EventArgs e)
        {
            string cor = "DarkSalmon";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnSkyBlue_Click(object sender, EventArgs e)
        {
            string cor = "SkyBlue";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnDeepSkyBlue_Click(object sender, EventArgs e)
        {
            string cor = "DeepSkyBlue";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnDarkViolet_Click(object sender, EventArgs e)
        {
            string cor = "DarkViolet";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnOrchid_Click(object sender, EventArgs e)
        {
            string cor = "Orchid";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            string cor = "Gold";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }

        private void btnGoldrod_Click(object sender, EventArgs e)
        {
            string cor = "Goldenrod";
            boTarefa.BOAtualizaCor(cor, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();
            tela.AtualizaColunas();
        }
        #endregion

        private void ConfigTarefa_Load(object sender, EventArgs e)
        {
            //Desabilita a Minimização
            this.MinimizeBox = false;
            //Formulário sempre a mostra
            this.TopMost = true;

            btnChartreuse.BackColor = Color.FromName("Chartreuse");
            btnDarkSalmon.BackColor = Color.FromName("Salmon");
            btnDarkViolet.BackColor = Color.FromName("DarkViolet");
            btnDeepSkyBlue.BackColor = Color.FromName("DeepSkyBlue");
            btnGold.BackColor = Color.FromName("Gold");
            btnGoldrod.BackColor = Color.FromName("Goldenrod");
            btnLightGreen.BackColor = Color.FromName("LightGreen");
            btnOrange.BackColor = Color.FromName("Orange");
            btnOrchid.BackColor = Color.FromName("Orchid");
            btnSalmon.BackColor = Color.FromName("Salmon");
            btnSkyBlue.BackColor = Color.FromName("SkyBlue");
            //btnWhite.BackColor = Color.FromName("White");
            btnYellowGreen.BackColor = Color.FromName("YellowGreen");

            string s = tarefa._TempoExecucao.ToString("ss");
            string m = tarefa._TempoExecucao.ToString("mm");
            string h = tarefa._TempoExecucao.ToString("hh");

            this.seg = Convert.ToInt16(s);
            this.min = Convert.ToInt16(m);
            this.hr = Convert.ToInt16(h);
            
            if(this.seg < 10)
                lblCronometro.Text = tarefa._TempoExecucao.ToShortTimeString() + ":0"+this.seg;
            else
                lblCronometro.Text = tarefa._TempoExecucao.ToShortTimeString() + ":" + this.seg;
            
        }

        private void AlteraTitulo(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            animation anime = new animation();
            animation.util.Animatte(pnlCalendario, animation.util.effect.Slide, 180, 0); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDate.Visible = true;
            lblQtdDias.Visible = true;
            lblDataFinal.Visible = true;             
            animation anime = new animation();
             animation.util.Animatte(pnlCalendario, animation.util.effect.Slide, 180, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblQtdDias.Visible = false;
            lblDataFinal.Visible = false;
            animation anime = new animation();
            animation.util.Animatte(pnlCalendario, animation.util.effect.Slide, 180, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = true;
            txtDescricao.Enabled = true;
        }

        private void lblQtdDias_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barraDeProgresso_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColuna.GetItemText(cmbColuna.SelectedItem))
            {
                case "To Do":
                    tarefa._Coluna = 1;
                    break;
                case "Doing":
                    tarefa._Coluna = 2;
                    break;
                case "Done":
                    tarefa._Coluna = 3;
                    break;
            }
            BOTarefa boTarefa = new BOTarefa();

            boTarefa.BOAtualizaColuna(tarefa._Coluna, tarefa._Id);

            tela.limpaColuna01();
            tela.limpaColuna02();
            tela.limpaColuna03();

            tela.AtualizaColunas();
        }


    }
}
