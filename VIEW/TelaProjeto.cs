using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Go.BO;
using System.Collections;
using Go.MODEL;
using Go.VIEW;
//Adicionando a biblioteca de tempo para realizar o efeito Slide:
using System.Runtime.InteropServices;

//using System.Windows.Media.Color;

//Referência para inputBox
using Microsoft.VisualBasic;

namespace Go.VIEW
{
    public partial class TelaProjeto : Form
    {
        Projeto proj = new Projeto();
        
        Tarefa tarefa = new Tarefa();
        BOTarefa boTarefa = new BOTarefa();
        BOProjeto boNovoProjeto = new BOProjeto();
        public int utilitario;      //Para uso da Foreign Key
        //public string color = "";
        public double tempoDeClique;

        public TelaProjeto()
        {
            InitializeComponent();
            EscondeColunas();
        }

        //base para o método de baixo
        int i = 1;

        private void btnCria_Click(object sender, EventArgs e)
        {
            TelaNovaTarefaColuna1 nTarefa = new TelaNovaTarefaColuna1(this);
            nTarefa.Show();
             
        }

        private void btnCriaTarefa2_Click(object sender, EventArgs e)
        {
            TelaNovaTarefaColuna1 coluna1 = new TelaNovaTarefaColuna1();
            coluna1.Show();
        }

        private void btnCriaTarefa3_Click(object sender, EventArgs e)
        {
            TelaNovaTarefaColuna3 nDone = new TelaNovaTarefaColuna3(this);
            //nDone.TopLevel = false;
            //pnlConfig.Controls.Add(nDone);
            //nDone.FormBorderStyle = FormBorderStyle.None;
            nDone.Show();

        }

        private void TelaProjetos_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
                    //Panel para login de projeto, caso tenha senha nele. 

                    pnl1.AllowDrop = true;
                    pnl2.AllowDrop = true;
                    pnl3.AllowDrop = true;

                    pnl1.DragEnter += panel_DragEnter;
                    pnl2.DragEnter += panel_DragEnter;
                    pnl3.DragEnter += panel_DragEnter;

                    pnl1.DragDrop += panel_DragDrop;
                    pnl2.DragDrop += panel_DragDrop;
                    pnl3.DragDrop += panel_DragDrop;
        }

//Métodos de dragDrop e de clique 
        public void botaoDinamico_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tarefa._Titulo = btn.Text;
            boTarefa.BOSelecionaId(tarefa);
            TelaConfigTarefa config = new TelaConfigTarefa(tarefa, this);
            config.Show();
 
        }


//TRATAMENTO DO DRAG DROP NO PANEL
        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }
//FIM DO TRATAMENTO DO DRAG DROP NO PANEL

        private bool DraggingFromGrid = false;
        private System.Drawing.Point DraggingStartPoint = new System.Drawing.Point();

//MouseUp - QUANDO SOLTA O MOUSE
        void button_MouseUp(object sender, MouseEventArgs e)
        {
 //           Stopwatch watch = ((sender as Button).Tag as Stopwatch);
            //          watch.Stop();
            if (DraggingFromGrid)
            {
                DraggingFromGrid = false;
            }

            #region Tentando com localização arcaica
            /*
            Button btn = (Button)sender;
            tarefa._Titulo = btn.Text;

            int localUp = Convert.ToInt16(btn.Location.Y);
                     if (local == localUp)
                        {
                            MessageBox.Show("Drag");
                            btn.DoDragDrop(btn, DragDropEffects.Move);
                        }
                        else
                        {
                            MessageBox.Show("Clique");
                        }
             */
            #endregion
            // watch.Reset();
        }

//MouseMove - Quando está movendo o botão
        void button_MouseMove(object sender, MouseEventArgs e)
        {
            if (DraggingFromGrid)
            {
                if (System.Math.Abs(e.X - DraggingStartPoint.X) > 10 ||
                    System.Math.Abs(e.Y - DraggingStartPoint.Y) > 10)
                {
                    StartDragging(sender, e);
                }
            }
            else
            {
                MessageBox.Show("just a click");
            }
        }



//MouseDown - QUANDO O BOTÃO DO MOUSE É PRESSIONADO
        void button_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DraggingFromGrid = true;
                DraggingStartPoint = new System.Drawing.Point(e.X, e.Y);
            }

            #region antigo com coments
            // MessageBox.Show(btn.Location.ToString());

/*            

            int loca = Convert.ToInt16(btn.Location.X);
            
            if (loca == 15)
            {
                MessageBox.Show("Drag");
                btn.DoDragDrop(btn, DragDropEffects.Move);
            }
            else
            {
                MessageBox.Show("Clique");
            }

            //MessageBox.Show(btn.Location.ToString());

/*
            Stopwatch watch = ((sender as Button).Tag as Stopwatch);
            
            Button btn = (Button)sender;
            tarefa._Titulo = btn.Text;

            if (watch.Elapsed.TotalMilliseconds >= 300.00)
            {
                MessageBox.Show("Passou de 300 mil");
                btn.DoDragDrop(btn, DragDropEffects.Move);
                watch.Stop();
                watch.Reset();
            }
            else
            {
                button_MouseUp(sender, e);
            }
            watch.Stop();
            watch.Reset();
*/  
#endregion
        }
        private void BotaoPressionado(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            tarefa._Titulo = btn.Text;

            if (tempoDeClique > 0 && tempoDeClique <= 90.0000)
                botaoDinamico_Click(sender, e);
           // else if (tempoDeClique > 150.00)
                //btn.DoDragDrop(btn, DragDropEffects.Move);  
        }

//Consumação do DRAG DROP
    private void StartDragging(object sender, MouseEventArgs e)
    {
        DraggingFromGrid = false;

        Button btn = (Button)sender;
        tarefa._Titulo = btn.Text;
        
        btn.DoDragDrop(btn, DragDropEffects.Move);  
    }

         
        public void CarregaComboBox()
        {


            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            boNovoProjeto.BOContaProjetos(proj);

            string nomeTitulo = "";
            for (i = 0; i <= Convert.ToInt32(proj._Registros); i++)
            {
                proj._Id = i;

                if (proj._Titulo == nomeTitulo)
                {
                    boNovoProjeto.BOSelecionaProjetos(proj);
                    comboBox1.Items.Add(proj._Titulo);
                    comboBox2.Items.Add(proj._Titulo);
                }
                nomeTitulo = proj._Titulo;
            }
        }

        public void limpaComboBox()
        {
            comboBox1.Items.Clear();
            CarregaComboBox();
        }

//Métodos de update e clear de coluna
        public void AtualizaColunas()
        { 
            boTarefa.BOContaTarefas(tarefa);

            int a = 15;
            int b = 21;
            int c = 20;
            int d = 20;
            int i = 20;

            List<Button> buttons = new List<Button>();
            for (i = 1; i <= Convert.ToInt32(tarefa._Registros); i++)
            {
                Button newButton = new Button();
                tarefa._Id = i;

                if (boTarefa.BOselecionaTarefa(tarefa))
                {
                     
                    switch (tarefa._Coluna)
                    {
                        case 1:
                            buttons.Add(newButton);
                            pnl1.Controls.Add(newButton);
                            newButton.Location = new Point(newButton.Location.X + a,
                            newButton.Location.Y + b);
                            b = b + 70;

                            newButton.ForeColor = Color.FromName("white");
                            newButton.Font = new Font("Century Gothic",14);
                            newButton.Text = tarefa._Titulo;
                            newButton.Height = 57;
                            newButton.Width = 280;
                            newButton.FlatStyle = FlatStyle.Flat;
                            newButton.FlatAppearance.BorderSize = 0;
                            newButton.BackColor = Color.FromName(tarefa._Cor);
                            break;
                        case 2:
                            buttons.Add(newButton);
                            pnl2.Controls.Add(newButton);
                            newButton.Location = new Point(newButton.Location.X + a,
                            newButton.Location.Y + c);
                            c = c + 70;
                            newButton.ForeColor = Color.FromName("white");
                            newButton.Font = new Font("Century Gothic",14);
                            newButton.Text = tarefa._Titulo;
                            newButton.Height = 57;
                            newButton.Width = 280;
                            newButton.FlatStyle = FlatStyle.Flat;
                            newButton.FlatAppearance.BorderSize = 0;
                            newButton.BackColor = Color.FromName(tarefa._Cor);

                            break;
                        case 3:
                            buttons.Add(newButton);
                            pnl3.Controls.Add(newButton);
                            newButton.Location = new Point(newButton.Location.X + a,
                            newButton.Location.Y + d);
                            d = d + 70;
                            newButton.ForeColor = Color.FromName("white");
                            newButton.Font = new Font("Century Gothic",14);
                            newButton.Text = tarefa._Titulo;
                            newButton.Height = 57;
                            newButton.Width = 280;
                            newButton.FlatStyle = FlatStyle.Flat;
                            newButton.FlatAppearance.BorderSize = 0;
                            newButton.BackColor = Color.FromName(tarefa._Cor);
                            break;
                        case 4:

                            break;
                    }
                        //newButton.MouseDown += BotaoPressionado;
                        newButton.Click += new System.EventHandler(this.botaoDinamico_Click);

                }
                //DRAG DROP ADIADO
                //newButton.Tag = new Stopwatch();
                // newButton.MouseDown += new MouseEventHandler(button_MouseDown);
                //newButton.MouseUp += new MouseEventHandler(button_MouseUp); 
                //newButton.MouseMove += new MouseEventHandler(button_MouseMove);
            }
        }

        public void limpaColuna01()
        {
            pnl1.Controls.Clear();
        }

        public void limpaColuna02()
        {
            pnl2.Controls.Clear();
        }

        public void limpaColuna03()
        {
            pnl3.Controls.Clear();
        }

        //Combobox de projetos da Tela do Kanban
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                proj._Titulo = (comboBox1.GetItemText(comboBox1.SelectedItem));

                boNovoProjeto.BOSelecionaDadosProjeto(proj);

                pnlConfig.BackColor = Color.FromName(proj._CorTopo);
                utilitario = tarefa._Id_Fk = proj._Id;

                pnlPomodoro.Visible = false;
                pnlTempo.Visible = false;
                btnPauseP.Visible = false;
                btnPlayP.Visible = false;

                timer1.Enabled = false;
                lblCronometro.Text = "25:00:00";
                lblCronometro2.Text = "25:00:00";
                mil = 60; 
                seg = 00;
                min = 25;

                //MessageBox.Show(proj._Senha);
                btnConfigProjeto.Visible = true;
            if (proj._Senha == "Tn3rD({)P")
            {
                pnlLoginProj.Visible = false;
                limpaColuna01();
                limpaColuna02();
                limpaColuna03();
                AtualizaColunas();
                pictureBox3.Visible = false;
                MostraColunas();
            }
            else
            {
                EscondeColunas();
                pnlLoginProj.Visible = true;
                lblApresentacao.Visible = false;
                //pictureBox3.Visible = true;
            }
        }

        //Adiciona projetos ao lado do Combobox de projetos
        private void btnAdicionaProjeto_Click(object sender, EventArgs e)
        {
            TelaNovoProjeto nProjeto = new TelaNovoProjeto(this);
            nProjeto.Show();

            limpaComboBox();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TelaNovaTarefaColuna1 nTarefa = new TelaNovaTarefaColuna1(this);
            nTarefa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //animation anime = new animation();
            //animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            //animation anime = new animation();
            //animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //animation anime = new animation();
            //animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);
        }

        private void btnCriaTarefa2_Click_1(object sender, EventArgs e)
        {
            TelaNovaTarefaColuna2 nDoing = new TelaNovaTarefaColuna2(this);
            //nDoing.TopLevel = false;
            //pnlConfig.Controls.Add(nDoing);
            //nDoing.FormBorderStyle = FormBorderStyle.None;
            nDoing.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaConfigProjeto user = new TelaConfigProjeto(proj, tarefa, this);
            user.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //pnl4.Show();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtSenha.Text == proj._Senha)
            {
                lblApresentacao.Hide();
                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                //gpb1.Show();
                //gpb2.Show();
                //gpb3.Show();
                //gpb4.Show();
                
                pnlLoginProj.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {

                MessageBox.Show("Senha errada, rapaz!");
            }

        }

        public void MostraColunas()
        {
            lblApresentacao.Hide();
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
        }

        public void EscondeColunas()
        {
            pnlLoginProj.Visible = false;

            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            //gpb1.Hide();
            //gpb2.Hide();
            //gpb3.Hide();
            //gpb4.Hide();

        }

        private void btnConfig_Click_1(object sender, EventArgs e)
        {

            pnlTempo.Visible = false;
            animation anime = new animation();
            animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);
            lblCronometro2.Visible = false; 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            proj._Titulo = (comboBox2.GetItemText(comboBox2.SelectedItem));

            boNovoProjeto.BOSelecionaDadosProjeto(proj);

            utilitario = tarefa._Id_Fk = proj._Id;

            pictureBox2.Visible = true;
            pnlConfig.Visible = true;
            pictureBox1.Visible = false;
            lblApresentacao2.Visible = false;
            btnNewProjt.Visible = false;
            comboBox2.Visible = false;
            comboBox1.Visible = true;
            btnPomodoro.Visible = true;
            btnAdicionaProjeto.Visible = true;


            mil = 60;
            seg = 00;
            min = 25;

            //MessageBox.Show(proj._Senha);
            btnConfigProjeto.Visible = true;
            if (proj._Senha == "Tn3rD({)P")
            {
                pnlLoginProj.Visible = false;
                limpaColuna01();
                limpaColuna02();
                limpaColuna03();
                AtualizaColunas();
                pictureBox3.Visible = false;

                MostraColunas();
            }
            else
            {
                EscondeColunas();
                pnlLoginProj.Visible = true;
                lblApresentacao.Visible = false;
                //pictureBox3.Visible = true;

            }
        }

        private void lblApresentacao_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TelaNovoProjeto nProjeto = new TelaNovoProjeto();
            nProjeto.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btnPauseP.Visible = true;
            btnPlayP.Visible = true;

            lblCronometro2.Visible = true;
            pnlTempo.Visible = true;
            timer1.Enabled = true;
        
        }


        //métodos ST GET para o pomodoro


        public int mil { get; set; }
        public int seg { get; set; }
        public int min { get; set; }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            mil--;

            if (mil == 00)
            {
                seg--;
                mil = 60;
            }
            else if (seg == 00)
            {
                min--;
                seg = 60;
            }
            else if (seg == 01 && mil == 01)
            {
                timer1.Enabled = false;
                min = 0;
                seg = 0;
                mil = 0;
            }

            lblCronometro.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0') + ":" + mil.ToString().PadLeft(2, '0');
            lblCronometro2.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0') + ":" + mil.ToString().PadLeft(2, '0');
            

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            animation anime = new animation();
            animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);

            btnPlayP.Visible = false;
            btnPauseP.Visible = false;
            pnlTempo.Visible = false;
            timer1.Enabled = false;
            lblCronometro.Text = "25:00:00";
            lblCronometro2.Text = "25:00:00";
            mil = 60;
            seg = 00;
            min = 25;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            animation anime = new animation();
            animation.util.Animatte(pnlPomodoro, animation.util.effect.Slide, 180, 0);


            
        }

        private void lblCronometro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

    }
}