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
            aluno1.SetMatricula("12345");

            Professor prof1 = new Professor();

            prof1.SetNome("Renato");
            prof1.SetSexo('M');
            prof1.NumeroRegistro = 777;

            Console.WriteLine("O nome do aluno é {0}. Ele é do sexo {1} e sua matrícula é {2}.", aluno1.GetNome(), aluno1.GetSexo(), aluno1.GetMatricula());

            Console.WriteLine("O nome do professor é {0}. Ele é do sexo {1} e seu número de registro é {2}.", prof1.GetNome(), prof1.GetSexo(), prof1.NumeroRegistro);
        }
    }
}
