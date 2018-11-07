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

namespace Go.DAOCONEXAO
{
    public class MySQL
    {
        public static MySqlConnection Conectar()
        {
            string stringConexao = "server=localhost;database=BD_GO;uid=root;pwd=;pooling = false";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static string CRUDandCount(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            
            string qtd = Convert.ToString(comando.ExecuteScalar());

            con.Close();
            
            return qtd;
        }

        public static MySqlDataReader Selecionar(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
          
            return dr;
        }
    }
}