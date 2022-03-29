using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int vetor[10];

            Aluno[] vet = new Aluno[3];
            vet[0] = new Aluno();
            vet[1] = new Aluno();
            vet[2] = new Aluno();

            vet[0].nome = "Robert";

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aluno
    {
        public string nome;
        public int matricula;
    }
}
