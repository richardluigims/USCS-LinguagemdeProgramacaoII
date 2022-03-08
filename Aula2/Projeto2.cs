using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;

            Console.Write("Digite a P1: ");
            x = float.Parse(Console.ReadLine());

            Console.Write("Digite a P2: ");
            y = float.Parse(Console.ReadLine());

            float media = (x + y) / 2;

            if (media >= 6)
                Console.WriteLine("Aprovado com média: " + media);
            else
                Console.WriteLine("Reprovado com média: " + media);
        }
    }
}
