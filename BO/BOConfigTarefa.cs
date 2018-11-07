using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using Go.DAO;
using System.Windows.Forms;


namespace Go.BO
{
    class BOConfigTarefa
    {
        DAO.DAOConfig daoConfig = new DAO.DAOConfig();
        DAO.DAOTarefa daoTarefa = new DAO.DAOTarefa();
        public void selectTarefa(Tarefa tarefa) {

            try
            {
                daoConfig.selectDescricao(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("O select falhou :(" + IO);
            }
        }

        public void BOAtualizaTempo(Tarefa tarefa)
        {
            try
            {
                daoConfig.UpdateTempo(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("O update da hora falhou :(" + IO);
            }        
        }

        public void BODeletaTarefa(Tarefa tarefa)
        {
            try
            {
                daoTarefa.DeleteTarefa(tarefa);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Ops! não deu pra deletar a tarefa  :(  - " + IO);
            }

        }

    }
}
