using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using Go.DAO;
using System.Windows.Forms;


namespace Go.BO
{
    class BOColunas
    {
        DAONovoProjeto daoNovoProjeto = new DAONovoProjeto();
        DAOColuna daoColuna = new DAOColuna();

        public void selecionaColunas(NovoProjeto nProjeto)
        {
            try
            {
                daoColuna.selecionaColunas(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar as colunas  :(  -" + IO);
            }
        }

        public void BOContaColunas(NovoProjeto nProjeto)
        {
            try
            {
                daoColuna.countColunas(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar as colunas  :(  -" + IO);
            }            
        }

        public void BOInsereColunas(NovoProjeto nProjeto)
        {
            try
            {
                daoColuna.insereColunas(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao inserir colunas  :(  -" + IO);
            }
        }

        
    }
}
