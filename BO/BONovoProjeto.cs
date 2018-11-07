using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using System.Windows.Forms;
using Go.DAO;

namespace Go.BO
{
    class BONovoProjeto
    {
        DAONovoProjeto daoNovoProjeto = new DAONovoProjeto();
        
        public void InserirProjeto(NovoProjeto nProjeto) 
        {
            if (Convert.ToInt16(daoNovoProjeto.ValidaNovoProjeto(nProjeto._Titulo)) == 1)
            {
                MessageBox.Show("Já existe um registro deste no banco!");
            }
            else
            {
                try
                {
                    daoNovoProjeto.insereNovoProjeto(nProjeto);
                    MessageBox.Show("Projeto gerado com sucesso :D ");
                }
                catch (Exception IO)
                {
                    MessageBox.Show("A inserção falhou :(   " + IO);
                }
            }
        }

        public void BOSelecionaProjetos(NovoProjeto nProjeto)
        {
            try
            {
                daoNovoProjeto.selecionaProjetos(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Não conseguimos selecionar :( "+ IO);
            }
        }

        public void BOContaProjetos(NovoProjeto nProjeto)
        { 
            try
            {
                daoNovoProjeto.countProjetos(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar a quantidade de projetos :(  - " + IO);
            }        

        }

        public void BOSelecionaId(NovoProjeto nProjeto)
        {
            try
            {
                daoNovoProjeto.selecionaId(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar a quantidade de projetos :(  - " + IO);
            }        
        
        
        }

        public void BOAtualizaProjeto(NovoProjeto nProjeto)
        {
            if (Convert.ToInt16(daoNovoProjeto.ValidaNovoProjeto(nProjeto._Titulo)) == 1)
            {
                MessageBox.Show("Já existe um registro deste no banco!");
            }
            else
            {
                try
                {
                    daoNovoProjeto.atualizaProjetos(nProjeto);
                }
                catch (Exception IO)
                {
                    MessageBox.Show("Não conseguimos atualizar o projeto!  :(  -" + IO);
                }
            }        
        }

    }
}
