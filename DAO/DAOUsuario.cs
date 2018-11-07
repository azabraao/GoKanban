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
    class DAOUsuario
    {

        Conf conf = new Conf();

        public void insertUsuario(Conf conf)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "Insert into TB_USUARIO (senha) " +
                "values (@senha)";

            comando.Parameters.AddWithValue("@senha", conf._Senha);


            MySQL.CRUD(comando);
        }
        public void selectUsuario(Conf conf)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT SENHA FROM TB_USUARIO";

            MySQL.CRUD(comando);

            MySqlDataReader dr = MySQL.Selecionar(comando);
            dr.Read();
            conf._Senha = (string)dr["SENHA"];
            MessageBox.Show(conf._Senha);
            dr.Close();
        }


    }
}
