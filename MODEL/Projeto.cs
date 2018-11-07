using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Go.MODEL
{
    public class Projeto
    {
        string titulo;
        string descricao;
        string registros;
        int id;
        private DateTime inicio = Convert.ToDateTime("28/08/1991 00:00:00");
        private DateTime fim = Convert.ToDateTime("21/08/1995 00:00:00");
        string senha = "Tn3rD({)P";
        string corTopo = "SteelBlue";
        int status = 1;
        string lembrete = " ";

        private int index = 1;



        public static int indice = 1;
        
        string[] title = new string[indice];
         

        public string _Title
        {
            get { return title[indice]; }
            set { title[indice] = value; }
        }

        public int _Index
        {
            get { return index; }
            set { index = value; indice = value; }
        }

        public static int _Indice
        {
            get { return Projeto.indice; }
            set { Projeto.indice = value; }
        }
         
        public string _Lembrete
        {
            get { return lembrete; }
            set { lembrete = value; }
        }
        public int _Status
        {
            get { return status; }
            set { status = value; }
        }



        public string _CorTopo
        {
            get { return corTopo; }
            set { corTopo = value; }
        }

        public string _Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public DateTime _Fim
        {
            get { return fim; }
            set { fim = value; }
        }

        public DateTime _Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
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
