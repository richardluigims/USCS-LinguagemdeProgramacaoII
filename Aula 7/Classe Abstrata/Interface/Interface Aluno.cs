using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAluno
    {
        void SetMatriculaNome(int matricula, string nome);
        String GetNome();
    }
}
