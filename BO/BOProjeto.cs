using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using System.Windows.Forms;
using Go.DAO;

namespace Go.BO
{
    class BOProjeto
    {
        DAOProjeto daoNovoProjeto = new DAOProjeto();
        
        public void BOInserirProjeto(Projeto nProjeto) 
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

        public void BOSelecionaProjetos(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.selecionaProjetos(nProjeto);
            }
            catch //(Exception IO)
            {
                //MessageBox.Show("Não conseguimos selecionar :( "+ IO);
            }
        }

        public void BOContaProjetos(Projeto nProjeto)
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

        public void BOSelecionaTudoProjetos(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.selecionaTudoProjetos(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar os projetos :(  - " + IO);
            }

        }

        public void BOSelecionaDadosProjeto(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.SelecionaDadosProjeto(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao contar a quantidade de projetos :(  - " + IO);
            }        
        
        
        }

        public void BOAtualizaProjeto(Projeto nProjeto)
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

        public void BOInsereInicio(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.insereInicio(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao selecionar o ID da tarefa  :(  - " + IO);
            }
        }

        public void BOInsereFim(Projeto nProjeto)
        {
            try
            {

                daoNovoProjeto.insereFim(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao inserir o Projeto :(  - " + IO);
            }
        }

        public void BOInsereSenha(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.InsereSenha(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao inserir senha :(  - " + IO);
            }
        }

        public void BOAtualizaTitulo(Projeto proj)
        {
            try
            {
                daoNovoProjeto.AtualizaTitulo(proj);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao atualizar título! :(  - " + IO);
            } 
        }

        public void BOAtualizaCor(string cor, int id)
        {
            try
            {
                daoNovoProjeto.UpdateCor(cor, id);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao atualizar cor  :(  -" + IO);
            }
        }

        public void BODeletaProjeto(Projeto nProjeto)
        {
            try
            {
                daoNovoProjeto.DeleteProjeto(nProjeto);
            }
            catch (Exception IO)
            {
                MessageBox.Show("Falha ao deletar projeto :(  - " + IO);
            }


        }

    }
}
