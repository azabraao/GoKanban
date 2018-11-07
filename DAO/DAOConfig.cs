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

namespace Go.DAO
{
    class DAOConfig
    {
        public void selectDescricao(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT DS_TAREFA, TEMPO_EXECUCAO, INICIO, FIM FROM TB_TAREFAS " +
                                   " WHERE ID_TAREFA = @ID";
            comando.Parameters.AddWithValue("@ID", tarefa._Id);
            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();
            tarefa._Descricao = (string)dr["DS_TAREFA"];
            DateTime tExec = (DateTime)dr["TEMPO_EXECUCAO"];
            tarefa._TempoExecucao = tExec;
            tarefa._Inicio = (DateTime)dr["INICIO"];
            tarefa._Fim= (DateTime)dr["FIM"];

        }

        public void UpdateTempo(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET TEMPO_EXECUCAO = @tExec WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@tExec", tarefa._TempoExecucao);
            comando.Parameters.AddWithValue("@id", tarefa._Id);

            MySQL.CRUD(comando);
        }

        public void UpdateTarefa(Tarefa tarefa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "UPDATE tb_tarefas SET DATA_EXCLUSAO = @exclusao WHERE ID_TAREFA = @id";
            comando.Parameters.AddWithValue("@descricao", tarefa._DataExclusao);

            MySQL.CRUD(comando);
        }
    }
}