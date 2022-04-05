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
            Aluno aluno1;
            aluno1 = new Aluno();

            aluno1.SetNome("Richard");
            aluno1.SetSexo('M');
            aluno1.matricula = "12345";

            Console.WriteLine("O nome do aluno é {0}. Ele é do sexo {1} e sua matrícula é {2}.", aluno1.GetNome(), aluno1.GetSexo(), aluno1.matricula);
        }
    }
}
