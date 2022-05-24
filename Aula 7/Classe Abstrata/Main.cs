using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente func1 = new Gerente();
            Contador func2 = new Contador();

            func1.Nome = "Jose"; func1.Matricula = 123; func1.Salario = 8050;
            func1.Mostra_funcionario();
            Console.WriteLine("Salario Antigo: {0}", func1.Salario);
            Console.WriteLine("Salario Novo: {0}", func1.Reajuste());

            func2.Nome = "Ana"; func2.Matricula = 456; func2.Salario = 4050;
            func2.Mostra_funcionario();
            Console.WriteLine("Salario Antigo: {0}", func2.Salario);
            Console.WriteLine("Salario Novo: {0}", func2.Reajuste());

            Console.ReadKey();
        }
    }
}
