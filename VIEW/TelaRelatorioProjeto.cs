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
//using Microsoft.VisualBasic.PowerPacks;


namespace Go.VIEW
{
    public partial class TelaRelatorioProjeto : Form
    {
        public TelaRelatorioProjeto(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;
        }
        BOTarefa boTarefa = new BOTarefa();
        Tarefa tarefa = null;

        private void RelatorioProjeto_Load(object sender, EventArgs e)
        {
            //1º Conta a quantidade de tarefas no projeto. A select faz uma seleção relativa as tarefas dentro do projeto em uso.
            //
            
            boTarefa.BOContaTarefasParaRelatório(tarefa);
            boTarefa.BOSelecionaID(tarefa);

            int a = 30;
            int b = 130;

            
            for (int i = 1; i <= Convert.ToInt32(tarefa._Registros); i++)
            {
                tarefa._Identificador = i;
                boTarefa.BOselecionaTarefaRelatorio(tarefa);
                if (tarefa._Coluna != 4)
                {
                    //INSTANCIANDO CADA LABEL QUE CONTERÁ A INFORMAÇÃO
                    Label lblTitulo = new Label();
                    Label lblInicio = new Label();
                    Label lblFinal = new Label();
                    Label lblTempo = new Label();
                    Label lblColuna = new Label();
                    Label lblPorcento = new Label();

                    //ADICIONANDO CADA LABEL NO FORM
                    Controls.Add(lblTitulo);
                    Controls.Add(lblInicio);
                    Controls.Add(lblFinal);
                    Controls.Add(lblTempo);
                    Controls.Add(lblColuna);
                    Controls.Add(lblPorcento);

                    //DANDO SUA LOCALIZAÇÃO
                    lblTitulo.Location = new Point(lblTitulo.Location.X + a,
                    lblTitulo.Location.Y + b);
                    lblInicio.Location = new Point(lblInicio.Location.X + 292,
                    lblInicio.Location.Y + b);
                    lblFinal.Location = new Point(lblFinal.Location.X + 537,
                    lblFinal.Location.Y + b);
                    lblTempo.Location = new Point(lblTempo.Location.X + 760,
                    lblTempo.Location.Y + b);
                    lblColuna.Location = new Point(lblColuna.Location.X + 981,
                    lblColuna.Location.Y + b);
                    lblPorcento.Location = new Point(lblPorcento.Location.X + 1256,
                    lblPorcento.Location.Y + b);

                    //SEM DEFINIR A LARGURA, ELE USA UMA LARGURA PADRÃO, QUE NÃO EXIBE TODA A QUANTIDADE DE CARACTERES QUE PRECISAMOS.
                    lblTitulo.Width = 150;
                    lblInicio.Width = 150;
                    lblFinal.Width = 150;
                    lblTempo.Width = 150;
                    lblColuna.Width = 150;
                    lblPorcento.Width = 150;

                    //SOMANDO PARA QUE QUANDO O FOR INCREMENTAR, POSSAMOS SETAR UMA LOCALIZAÇÃO DIFERENTE PARA A LABEL. (VEJA NO LOCATION)
                    b = b + 100; 

                    //PRIMEIRA COLUNA: TÍTULO.                
                    lblTitulo.Text = tarefa._Titulo;


                    //TRATAMENTO PARA SEGUNDA E TERCEIRA COLUNAS: INÍCIO E FIM.
                    //HÁ UM INÍCIO SETADO POR DEFAULT, QUE SERVE DE REFERÊNCIA. É UMA DATA QUE NÃO PODE SER USADA PARA 
                    //INÍCIO DE TAREFA. OS DADOS DEFAULT SÃO: INÍCIO - 21/08/1995 e FIM - 28/08/1995
                    if (tarefa._Inicio.ToShortDateString() == "28/08/1991")
                        lblInicio.Text = "Não definido";
                    else
                        lblInicio.Text = tarefa._Inicio.ToShortDateString();

                    if (tarefa._Fim.ToShortDateString() == "21/08/1995")
                        lblFinal.Text = "Não definido";
                    else
                        lblFinal.Text = tarefa._Fim.ToShortDateString();


                    //INSERÇÃO DO TEMPO LEVADO NA TAREFA
                    lblTempo.Text = tarefa._TempoExecucao.ToShortTimeString();

                    //TRATAMENTO DA INFORMAÇÃO CONTIDA NO BANCO. AS COLUNAS TEM IDENTIFICADORES: 1 2 e 3.
                    switch (tarefa._Coluna)
                    {
                        case 1:
                            lblColuna.Text = "TO DO";
                            break;
                        case 2:
                            lblColuna.Text = "DOING";
                            break;
                        case 3:
                            lblColuna.Text = "DONE";
                            lblColuna.ForeColor = Color.FromName("Red");
                            break;
                    }

                    //PORCENTAGEM DE TEMPO PASSADO PARA CONCLUSÃO DA TAREFA.

                    TimeSpan QtdDias = tarefa._Fim - tarefa._Inicio;
                    int dias = QtdDias.Days;

                    TimeSpan diasPassadosTimeSpan = tarefa._Fim - DateTime.Now;
                    int diasPassados = diasPassadosTimeSpan.Days;

                    if (dias != 0 && tarefa._Fim.ToShortDateString() != "21/08/1995" && tarefa._Inicio.ToShortDateString() != "28/08/1991")
                    {
                        int A = dias * 100;
                        int B = A / diasPassados;

                        lblPorcento.Text = B.ToString()+"%";
                        MessageBox.Show("FIM: " + tarefa._Fim.ToShortDateString());
                        MessageBox.Show("INÍCIO: " + tarefa._Inicio.ToShortDateString());
                    }
                    else
                    {
                        lblPorcento.Text = "";
                    }
                    //BUSCANDO A COR DA TAREFA NO BANCO E PONDO ISTO NA COR DA LABEL CORRESPONDENTE A TAREFA.
                    lblTitulo.ForeColor = Color.FromName(tarefa._Cor);

/*
                    //LINHA QUE FORMA A TABELA
                    ShapeContainer canvas = new ShapeContainer();
                    LineShape theLine = new LineShape();
                    // Set the form as the parent of the ShapeContainer.
                    canvas.Parent = this;
                    // Set the ShapeContainer as the parent of the LineShape.
                    theLine.Parent = canvas;
                    // Set the starting and ending coordinates for the line.
                    theLine.StartPoint = new System.Drawing.Point(28, x);
                    theLine.EndPoint = new System.Drawing.Point(1280, x);
                    x = x + 100;
 */
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível no momento.");
        } 

    }
}
