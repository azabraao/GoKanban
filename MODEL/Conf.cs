using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Go.MODEL
{
    public class Conf
    {
        string usuario;
        string senha;
        bool booleano;


        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        
        public string _Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        
        public bool _Booleano
        {
            get { return booleano; }
            set { booleano = value; }
        }


    }
}
