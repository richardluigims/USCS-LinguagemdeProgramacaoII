using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aluno
    {
        private string nome;
        private int matricula;

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get ; set ; }
    }
}

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

            vet[0].Nome = "Robert";

        

            Console.ReadKey();
        }
    }
}
