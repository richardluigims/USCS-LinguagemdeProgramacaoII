using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Professor : Pessoa
    {
        private int numeroCadastro;
        private int Sala;

        public int GetNumeroCadastro()
        {
            return this.numeroCadastro;
        }

        public int GetSala()
        {
            return this.Sala;
        }

        public void SetNumeroCadastro (int numeroCadastro)
        {
            this.numeroCadastro = numeroCadastro;
        }

        public void SetSala (int Sala)
        {
            this.Sala = Sala;
        }
    }
}
