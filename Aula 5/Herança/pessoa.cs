using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pessoa
    {
        private string nome;
        private char sexo;

        public string GetNome()
        {
            return this.nome;
        }

        public char GetSexo()
        {
            return this.sexo;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetSexo(char sexo)
        {
            this.sexo = sexo;
        }
    }
}
