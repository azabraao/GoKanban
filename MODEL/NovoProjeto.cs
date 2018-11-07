using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Go.MODEL
{
    public class NovoProjeto
    {
        string titulo;
        string descricao;
        string registros;
        int id;

        public int _Id
        {
            get { return id; }
            set { id = value; }
        }

        public string _Registros
        {
            get { return registros; }
            set { registros = value; }
        }

        public string _Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string _Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

    }
}
