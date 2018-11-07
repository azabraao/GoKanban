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
    class DAOTarefa
    {
        Tarefa tarefaModel = new Tarefa();

        public void InsertTarefa(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "Insert into TB_TAREFAS (tarefas_id_projeto, coluna, titulo_tarefa, ds_tarefa, prioridade, inicio, fim, tempo_execucao, data_criacao) " +
                "values (@Id_Fk, @coluna, @titulo, @descricao, @cor, @inicio, @fim, @tExec, @criacao)";
            //tarefa._Id_Fk = 1;
            comando.Parameters.AddWithValue("@Id_Fk", tarefa._Id_Fk);
            comando.Parameters.AddWithValue("@coluna", tarefa._Coluna);
            comando.Parameters.AddWithValue("@titulo", tarefa._Titulo);
            comando.Parameters.AddWithValue("@descricao", tarefa._Descricao);
            comando.Parameters.AddWithValue("@cor", tarefa._Cor);
            comando.Parameters.AddWithValue("@inicio", tarefa._Inicio);
            comando.Parameters.AddWithValue("@fim", tarefa._Fim);
            comando.Parameters.AddWithValue("@tExec", tarefa._TempoExecucao);
            comando.Parameters.AddWithValue("@criacao", tarefa._DataCriacao);

            
            MySQL.CRUD(comando);
        }

        public void selectTarefa(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT TAREFAS_ID_PROJETO, COLUNA, TITULO_TAREFA, DS_TAREFA, INICIO, FIM, PRIORIDADE, TEMPO_EXECUCAO FROM TB_TAREFAS " +
                                   " WHERE ID_TAREFA = @ID and TAREFAS_ID_PROJETO = @Id_Fk";

            comando.Parameters.AddWithValue("@ID", tarefa._Id);
            comando.Parameters.AddWithValue("@Id_Fk", tarefa._Id_Fk);

            MySQL.CRUD(comando);

            
            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();

                tarefa._Titulo = (string)dr["TITULO_TAREFA"];
                tarefa._Descricao = (string)dr["DS_TAREFA"];
                tarefa._Id_Fk = (int)dr["TAREFAS_ID_PROJETO"];
                tarefa._Cor = (string)dr["PRIORIDADE"];
                tarefa._Coluna = (int)dr["COLUNA"];
                DateTime tempoExec = (DateTime)dr["TEMPO_EXECUCAO"];
                DateTime fim = (DateTime)dr["FIM"];
                DateTime inicio = (DateTime)dr["INICIO"];
                tarefa._TempoExecucao = tempoExec;
                tarefa._Fim = fim;
                tarefa._Inicio = inicio;

            dr.Close();
        } 

        public string SelectTituloTarefa(string titulo) {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_tarefa) from tb_tarefas where TITULO_TAREFA LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", titulo);

                string qtd = MySQL.CRUDandCount(comando);

                return qtd; //Vai retornar 0 ou 1            
        }

        public void UpdateTarefa(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET COLUNA = @coluna, TITULO_TAREFA = @titulo, DS_TAREFA = @descricao WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@coluna", tarefa._Coluna);
            comando.Parameters.AddWithValue("@id", tarefa._Id);
            comando.Parameters.AddWithValue("@titulo", tarefa._Titulo);
            comando.Parameters.AddWithValue("@descricao", tarefa._Descricao);

            MySQL.CRUD(comando);
        }

        public void DeleteTarefa(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET DATA_EXCLUSAO = @exclusao, COLUNA = 4 WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@id", tarefa._Id);
            comando.Parameters.AddWithValue("@exclusao", tarefa._DataExclusao);

            MySQL.CRUD(comando);         
        }

        public void UpdateTarefa(int coluna, int id, string descricao)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET DS_TAREFA = @descricao WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@descricao", descricao);

            MySQL.CRUD(comando);
        }

        public void UpdateColuna(int coluna, int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET Coluna = @coluna WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@coluna", coluna);
            comando.Parameters.AddWithValue("@id", id);

            MySQL.CRUD(comando);
        }

        public void UpdateCor(string cor, int id) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET PRIORIDADE = @cor WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cor", cor);

            MySQL.CRUD(comando);            
        }

        public void selecionaId(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT ID_TAREFA FROM TB_TAREFAS where TITULO_TAREFA LIKE @titulo";
            comando.Parameters.AddWithValue("@titulo", tarefa._Titulo);
            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();
            tarefa._Id = (int)dr["ID_TAREFA"];

            dr.Close();
        }

        public void countTarefas(Tarefa tarefa) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_tarefa) from tb_tarefas";
            string qtd = MySQL.CRUDandCount(comando);
            
            tarefa._Registros = qtd;
        }

        //Temporário: Count das tarefas para uso do relatório. Colocar esse count para a seleção de tarefas nos panels depois.
        public void countTarefasParaRelatorio(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(TITULO_tarefa) from tb_tarefas WHERE TAREFAS_ID_PROJETO = @id_fk";
            comando.Parameters.AddWithValue("@id_fk", tarefa._Id_Fk);
            string qtd = MySQL.CRUDandCount(comando);

            tarefa._Registros = qtd;
        }

        public void selectID(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT ID_TAREFA FROM TB_TAREFAS WHERE TAREFAS_ID_PROJETO = @Id_Fk";
            comando.Parameters.AddWithValue("@Id_Fk", tarefa._Id_Fk);

            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);

            int cont = 1;
            while (dr.Read())
            {
                tarefa._Identificador = cont;
                tarefa._IdRel = (int)dr["ID_TAREFA"];

                cont++;
               // MessageBox.Show(tarefa._IdRel.ToString());
            }

            dr.Close();
        }

        public void selectTarefaRelatorio(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT TAREFAS_ID_PROJETO, COLUNA, TITULO_TAREFA, DS_TAREFA, INICIO, FIM, PRIORIDADE, TEMPO_EXECUCAO FROM TB_TAREFAS " +
                                   " WHERE ID_TAREFA = @ID and TAREFAS_ID_PROJETO = @Id_Fk";
            //tarefa._IdRel = 1;
            //MessageBox.Show(tarefa._IdRel.ToString());
            comando.Parameters.AddWithValue("@ID", tarefa._IdRel);
            comando.Parameters.AddWithValue("@Id_Fk", tarefa._Id_Fk);

            MySQL.CRUD(comando);


            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();

            tarefa._Titulo = (string)dr["TITULO_TAREFA"];
            tarefa._Descricao = (string)dr["DS_TAREFA"];
            tarefa._Id_Fk = (int)dr["TAREFAS_ID_PROJETO"];
            tarefa._Cor = (string)dr["PRIORIDADE"];
            tarefa._Coluna = (int)dr["COLUNA"];
            DateTime tempoExec = (DateTime)dr["TEMPO_EXECUCAO"];
            DateTime fim = (DateTime)dr["FIM"];
            DateTime inicio = (DateTime)dr["INICIO"];
            tarefa._TempoExecucao = tempoExec;
            tarefa._Fim = fim;
            tarefa._Inicio = inicio;

            dr.Close();
        }

        public void insereInicio(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET inicio= @inicio WHERE ID_TAREFA = @id;";
            comando.Parameters.AddWithValue("@inicio", tarefa._Inicio);
            comando.Parameters.AddWithValue("@id", tarefa._Id);

            MySQL.CRUD(comando);
        }

        public void insereFim(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET fim = @fim WHERE ID_TAREFA = @id;";
            comando.Parameters.AddWithValue("@fim", tarefa._Fim);
            comando.Parameters.AddWithValue("@id", tarefa._Id);

            MySQL.CRUD(comando);
        }
    }
}
