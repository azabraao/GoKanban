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
    class DAOProjeto
    {
        string tit;

        public void insereNovoProjeto(Projeto nProjeto) 
        {
             MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "insert into tb_projetos (titulo_projeto, ds_projeto, senha_projeto, istatus, lembrete_senha, cor_topo)"+
                "values (@titulo, @descricao, @senha, @status, @lembrete, @corTopo)";

            comando.Parameters.AddWithValue("@senha", nProjeto._Senha);
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            comando.Parameters.AddWithValue("@descricao", nProjeto._Descricao);
            comando.Parameters.AddWithValue("@status", nProjeto._Status);
            comando.Parameters.AddWithValue("@lembrete", nProjeto._Lembrete);
            comando.Parameters.AddWithValue("@corTopo", nProjeto._CorTopo);
            MySQL.CRUD(comando); 
        }

        public string ValidaNovoProjeto(String titulo) {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_PROJETO) from tb_projetos where TITULO_PROJETO LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", titulo);

            string qtd = MySQL.CRUDandCount(comando);
    

            return qtd; //Vai retornar 0 ou 1          
        }

        public void selecionaTudoProjetos(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM TB_PROJETOS " +
                                    "WHERE istatus = 1";

            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            
            dr.Read();

            int cont = 1;

            while (dr.Read())
            {
                string[] titulo = new string[10000];
                nProjeto._Index = cont;
                nProjeto._Title = (string)dr["TITULO_PROJETO"];

                cont++;
                MessageBox.Show("Ainda não: "+nProjeto._Title);
            }

        }

        public void selecionaProjetos(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT TITULO_PROJETO, DS_PROJETO, SENHA_PROJETO, COR_TOPO, ISTATUS FROM TB_PROJETOS "+
                                    "WHERE ID_PROJETO = @id and istatus = 1";

            comando.Parameters.AddWithValue("@id", nProjeto._Id);

            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();

            nProjeto._Senha = (string)dr["SENHA_PROJETO"];
            nProjeto._Titulo = (string)dr["TITULO_PROJETO"];
            nProjeto._Descricao = (string)dr["DS_PROJETO"];
            nProjeto._CorTopo = (string)dr["COR_TOPO"];
            nProjeto._Status = (int)dr["ISTATUS"];



            //Só pra provar que o array funfa
/*
            string[] testeCadeia = new string[2000];
            testeCadeia[1] = "teste cadeia";
            testeCadeia[2] = "segundo teste";
            int cont = 1;

            while(cont < 7){

                MessageBox.Show(testeCadeia[cont]);
                
                cont++;
            }

 */ 
        }

        public void SelecionaDadosProjeto(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT ID_PROJETO,SENHA_PROJETO, COR_TOPO FROM TB_PROJETOS where TITULO_PROJETO LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();

            nProjeto._Senha = (string)dr["SENHA_PROJETO"];
            nProjeto._Id = (int)dr["ID_PROJETO"];
            nProjeto._CorTopo = (string)dr["COR_TOPO"];

       }

        public void countProjetos(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_PROJETO) from tb_projetos";
            string qtd = MySQL.CRUDandCount(comando);

            nProjeto._Registros = qtd;
        }

        public void atualizaProjetos(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET DS_PROJETO = @descricao, TITULO_PROJETO = @titulo WHERE ID_PROJETO = @id";
            
            comando.Parameters.AddWithValue("@descricao", nProjeto._Descricao);
            comando.Parameters.AddWithValue("@titulo", nProjeto._Titulo);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);
            MySQL.CRUD(comando);            
        }

        public void insereInicio(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET INICIO_PROJETO = @inicio WHERE ID_PROJETO = @id;";
            comando.Parameters.AddWithValue("@inicio", nProjeto._Inicio);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);

            MySQL.CRUD(comando);
        }

        public void insereFim(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET FIM_PROJETO = @fim WHERE ID_PROJETO = @id;";
            comando.Parameters.AddWithValue("@fim", nProjeto._Fim);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);

            MySQL.CRUD(comando);
        }

        public void InsereSenha(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET senha_projeto = @senha, LEMBRETE_SENHA = @lembrete WHERE ID_PROJETO = @id;";
            comando.Parameters.AddWithValue("@senha", nProjeto._Senha);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);
            comando.Parameters.AddWithValue("@lembrete", nProjeto._Lembrete);

            MySQL.CRUD(comando);
        }

        public void AtualizaTitulo(Projeto proj)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET TITULO_PROJETO = @titulo WHERE ID_PROJETO = @id";


            comando.Parameters.AddWithValue("@titulo", proj._Titulo);
            MessageBox.Show(proj._Titulo);
            comando.Parameters.AddWithValue("@id", proj._Id);

            MySQL.CRUD(comando);   
        
        }

        public void insereCorTopo(Projeto nProjeto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "Insert tb_projetos SET INICIO_PROJETO = @inicio WHERE ID_PROJETO = @id; ";
            comando.Parameters.AddWithValue("@inicio", nProjeto._Inicio);
            comando.Parameters.AddWithValue("@id", nProjeto._Id);

            MySQL.CRUD(comando);
        }

        public void UpdateCor(string cor, int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET cor_topo = @cor WHERE ID_projeto = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cor", cor);

            MySQL.CRUD(comando);
        }

        public void DeleteProjeto(Projeto proj)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_projetos SET istatus = @status WHERE ID_projeto = @id";
            comando.Parameters.AddWithValue("@id", proj._Id);
            comando.Parameters.AddWithValue("@status", proj._Status);
            MySQL.CRUD(comando);
        }
    }
}