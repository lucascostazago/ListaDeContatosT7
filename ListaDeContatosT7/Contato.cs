using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT7
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        // propriedades (get e set)
        // é um controle de acesso as variaveis.

        public string Nome { 
            get 
            {  
                return nome; 
            } 
            set 
            {  
                nome = value; 
            } 
        }

        public string Sobrenome
        {
            get 
            { 
            return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                } else
                {
                    telefone = "00 00000-0000";
                }
            }
        }

        //O metodo que tem o mesmo nome da classe
        //e nao retorna nada, é chamado de construtor
        //da CLASSE
        public Contato()
        {
            Nome = "Lucas";
            Sobrenome = "Zago";
            Telefone = "11 98765-4321";
        }
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //sobrescrve o metodo ToString()
        //polimofismo
        public override string ToString()
        {
            string saida = string.Empty; //Boa pratica de programacao
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0,2), Telefone.Substring(2,5), Telefone.Substring(7,4));
            return saida;

        }
    }
}
