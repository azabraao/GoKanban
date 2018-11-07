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
    public partial class TelaNovaTarefaColuna2 : Form
    {
        public TelaNovaTarefaColuna2()
        {
            InitializeComponent();
        }

        public TelaNovaTarefaColuna2(TelaProjeto tela)
        {
            InitializeComponent();
            this.tela = tela;
        }
        TelaProjeto tela = null;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Ué, sua tarefa não tem titulo?");
            }
            else if (tela.utilitario == 0)
            {
                MessageBox.Show("Selecione um projeto");
            }
            else
            { 
                Tarefa tarefa = new Tarefa();

                tarefa._Titulo = txtTitulo.Text;
                tarefa._Descricao = txtDescricao.Text;
                tarefa._Coluna = 2;
                tarefa._Id_Fk = tela.utilitario;
                BOTarefa boTarefa = new BOTarefa();

                boTarefa.BOInsereTarefa(tarefa);

                tela.limpaColuna01();
                tela.AtualizaColunas();


                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaNovaTarefaColuna2_Load(object sender, EventArgs e)
        {
            txtTitulo.Focus();
        }


    }
}
