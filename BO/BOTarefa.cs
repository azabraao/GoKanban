using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using Go.DAO;
using System.Windows.Forms;

namespace Go.BO
{
    class BOTarefa
    {
        DAOTarefa daoTarefa = new DAOTarefa();

        public void BOInsereTarefa(Tarefa tarefa) {

            if (Convert.ToInt16(daoTarefa.SelectTituloTarefa(tarefa._Titulo)) == 1)
            {
              MessageBox.Show("Já existe um registro deste no banco!");
            }
            else
            {
                try
                {
                    daoTarefa.InsertTarefa(tarefa);
                }
                catch (Exception IO)
                {
                    MessageBox.Show("Erro ao cadastrar nova tarefa - " + IO);
                }
            }
        }

        public Boolean BOselecionaTarefa(Tarefa tarefa)
        {

            try
            {
                daoTarefa.selectTarefa(tarefa);

                return true;
            }
            catch//(Exception IO)
            {
                //MessageBox.Show("erro   - " + IO);
                return false;
            }
        }

        //Select de tarefa do relatorio
        public Boolean BOselecionaTarefaRelatorio(Tarefa tarefa)
        {

            try
            {
                daoTarefa.selectTarefaRelatorio(tarefa);

                return true;
            }
            catch (Exception IO)
            {
                MessageBox.Show("erro   - " + IO);
                return false;
            }
        }

        public void BOAtualizaTarefa(int coluna, int id, string descricao)
        {

            try
            {
                daoTarefa.UpdateTarefa(coluna, id, descricao);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao atualizar tarefa  :(  -" + IO);
            }
        }

        public void BOAtualizaColuna(int coluna, int id)
        {

            try
            {
                daoTarefa.UpdateColuna(coluna, id);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao atualizar coluna  :(  -" + IO);
            }
        } 

        public void BOAtualizaTarefa(Tarefa tarefa)
        {
            if (Convert.ToInt16(daoTarefa.SelectTituloTarefa(tarefa._Titulo)) == 1)
            {
                MessageBox.Show("Já existe um registro deste no banco!");
            }
            else
            {
                try
                {
                    daoTarefa.UpdateTarefa(tarefa);
                }
                catch (Exception IO)
                {
                    MessageBox.Show("Falha ao atualizar tarefa  :(  -" + IO);
                }
            }
        }

        public void BOAtualizaCor(string cor, int id)
        {
            try
            {
                daoTarefa.UpdateCor(cor, id);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao atualizar cor  :(  -" + IO);
            }            
        }

        public void BOSelecionaId(Tarefa tarefa)
        {
            try
            {
                daoTarefa.selecionaId(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar o ID da tarefa  :(  - " + IO);
            }    
        }

        public void BOContaTarefas(Tarefa tarefa)
        {
            try
            {
                daoTarefa.countTarefas(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar a quantidade de registros :(  - " + IO);
            }        
        
        }

        //NOME TEMPORÁRIO. PARA USO DO RELATÓRIO.
        public void BOContaTarefasParaRelatório(Tarefa tarefa)
        {
            try
            {
                daoTarefa.countTarefasParaRelatorio(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar a quantidade de tarefas para o relatorio :(  - " + IO);
            }

        }

        public void BOSelecionaID(Tarefa tarefa)
        {
            try
            {
                daoTarefa.selectID(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar o ID :(  - " + IO);
            }       
        
        }

        public void BOInsereInicio(Tarefa tarefa)
        {
            try
            {
                daoTarefa.insereInicio(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar o ID da tarefa  :(  - " + IO);            
            }
        }

        public void BOInsereFim(Tarefa tarefa)
        {
            try
            {
                daoTarefa.insereFim(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar o ID da tarefa  :(  - " + IO);
            }
        }

    }
}
