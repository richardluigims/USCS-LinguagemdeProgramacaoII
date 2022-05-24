using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Aluno : IAluno
    {
        protected int Matricula;
        protected string Nome;

        public void SetMatriculaNome (int pID, string pName)
        {
            Matricula = pID;
            Nome = pName;
        }

        public String GetNome()
        {
            return Nome;
        }
    }
}
