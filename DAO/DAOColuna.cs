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
    class DAOColuna
    {

        public void countColunas(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(ID_COLUNA) from tb_colunas where ID_PROJETO_COLUNAS = @id_fk";
            comando.Parameters.AddWithValue("@id_fk", nProjeto._IdColunaFk);

            string qtd = MySQL.CRUDandCount(comando);

            int quantidade = Convert.ToInt16(qtd);
            nProjeto._QtdColunas = quantidade;
        }

        public void DAOInsereColuna(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "insert into tb_colunas (id_projeto_colunas, nome_coluna)" +
                "values (@id, @descricao)";
            comando.Parameters.AddWithValue("@id", nProjeto._Titulo);
            comando.Parameters.AddWithValue("@descricao", nProjeto._Descricao);

            // MessageBox.Show(comando.CommandText);
            MySQL.CRUD(comando);        
        }

        public void selecionaColunas(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT id_coluna, nome_coluna FROM TB_COLUNAS WHERE ID_PROJETO_COLUNAS = @id_fk";
            comando.Parameters.AddWithValue("@id_fk", nProjeto._IdColunaFk);
            comando.Parameters.AddWithValue("@id", nProjeto._IdColuna);

            MySQL.CRUD(comando);
            MySqlDataReader dr = MySQL.Selecionar(comando);

            dr.Read();

            nProjeto._IdColuna = (int)dr["ID_COLUNA"];
            nProjeto._NomeColuna = (string)dr["NOME_COLUNA"];
        }

        public void insereColunas(NovoProjeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "insert into tb_colunas(id_projeto_COLUNAS, NOME_COLUNA) values (@id_fk, @nomeColuna);";
            comando.Parameters.AddWithValue("@id_fk", nProjeto._IdColunaFk);
            comando.Parameters.AddWithValue("@nomeColuna", nProjeto._NomeColuna);
            
            MessageBox.Show("FK: " + nProjeto._IdColunaFk + " e ID: " + nProjeto._NomeColuna);
            MySQL.CRUD(comando);           
        }

    }
}
