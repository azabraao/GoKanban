using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Go.MODEL;
using MySql.Data;
using MySql.Data.MySqlClient;
using Go.DAOCONEXAO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Go.DAO
{
    class DAONovoProjeto
    {
        public void insereNovoProjeto(NovoProjeto nProjeto) 
        {
             MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "insert into tb_projetos (titulo_projeto, ds_projeto)"+ 
                "values (@titulo, @descricao)";
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            comando.Parameters.AddWithValue("@descricao", nProjeto._Descricao);

           // MessageBox.Show(comando.CommandText);
            MySQL.CRUD(comando); 
        }

        public string ValidaNovoProjeto(String titulo) {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_PROJETO) from tb_projetos where TITULO_PROJETO LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", titulo);

            string qtd = MySQL.CRUDandCount(comando);
    

            return qtd; //Vai retornar 0 ou 1          
        }

        public void selecionaProjetos(NovoProjeto nProjeto) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT TITULO_PROJETO, DS_PROJETO FROM TB_PROJETOS "+
                                    "WHERE ID_PROJETO = @id";

            comando.Parameters.AddWithValue("@id", nProjeto._Id);

            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();

            nProjeto._Titulo = (string)dr["TITULO_PROJETO"];
            nProjeto._Descricao = (string)dr["DS_PROJETO"];
        }

        public void selecionaId(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT ID_PROJETO FROM TB_PROJETOS where TITULO_PROJETO LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();
            nProjeto._Id = (int)dr["ID_PROJETO"];

       }

        public void countProjetos(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_PROJETO) from tb_projetos";
            string qtd = MySQL.CRUDandCount(comando);

            nProjeto._Registros = qtd;
        }

        public void atualizaProjetos(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET DS_PROJETO = @descricao, TITULO_PROJETO = @titulo WHERE ID_PROJETO = @id";
            
            comando.Parameters.AddWithValue("@descricao", nProjeto._Descricao);
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);
            MySQL.CRUD(comando);            
        }
    }
}
