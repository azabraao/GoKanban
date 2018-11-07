using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Go.MODEL
{
    public class Tarefa
    {
        private int id;
        private int[] idRel = new int[2000];

        private string titulo;
        private string registros;
        private string descricao;
        private int id_Fk;
        private int coluna;
        private string cor = "gray";
        private DateTime inicio = Convert.ToDateTime("28/08/1991 00:00:00");
        private DateTime fim = Convert.ToDateTime("21/08/1995 00:00:00");

        public static DateTime time = Convert.ToDateTime("00:00:00");
        private DateTime tempoExecucao = time;
        private DateTime dataCriacao = DateTime.Now;
        private DateTime dataExclusao = DateTime.Now;


        int identificador = 1;



        public int _IdRel
        {
            get { return idRel[identificador]; }
            set { idRel[identificador] = value; }
        }

        public int _Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public DateTime _DataExclusao
        {
            get { return dataExclusao; }
            set { dataExclusao = value; }
        }

        public DateTime _DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        public DateTime _TempoExecucao
        {
            get { return tempoExecucao; }
            set { tempoExecucao = value; }
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


        public string _Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int _Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        public int _Id_Fk
        {
            get { return id_Fk; }
            set { id_Fk = value; }
        }


        public string _Descricao
        {
            get { return descricao; }
            set {descricao = value; }
        }

        public string _Registros
        {
            get { return registros; }
            set { registros = value; }
        }


        public string _Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int _Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
