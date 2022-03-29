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

            int [] vet = new int[10]; // criar vetor, é diferente de C

            for (int i = 0; i < 10; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int num = 0; num < 10; num++)
            {
                Console.WriteLine("Na posição {0} tem o numero {1}", num, vet[num], vet[num]);
            }
        }
    }
}
