using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aluno : Pessoa
    {
        private string matricula;

        public string GetMatricula()
        {
            return this.matricula;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }
    }
}
