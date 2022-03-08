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

            Console.Write("Digite o primeiro número: ");
            x = float.Parse(Console.ReadLine()); // comando para pedir valor (equivalente ao scanf)

            Console.Write("Digite o segundo número: "); // console.write (sem line) para não pular linha
            y = float.Parse(Console.ReadLine());

            Console.Write("A soma é: ");
            Console.WriteLine(x+y);
        }
    }
}
