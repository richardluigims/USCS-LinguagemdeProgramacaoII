using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno();
            alu.SetMatriculaNome(3456, "Ana Souza");
            Console.WriteLine(alu.GetNome());
            Console.ReadKey();
        }
    }
}
