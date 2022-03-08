using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //classe vem antes do objeto 
            Aluno ric, and, gab, edu; // não é recomendável criar objetos com nomes, por conta da quantidade
            edu = new Aluno();
            edu.nome = "Eduardo Limoeiro";
            edu.idade = 78;
            edu.p1 = 9.8;
            edu.p2 = 1.2;

            ric = new Aluno();
            ric.nome = "Richard Santos";
            ric.idade = 32;
            ric.p1 = 3.5;
            ric.p2 = 8;

            Console.WriteLine(edu.nome + " " + edu.idade + " " + edu.p1 + " " + edu.p2 + " " + edu.CalcularMedia());

            Console.WriteLine(ric.nome + " " + ric.idade + " " + ric.p1 + " " + ric.p2 + " " + ric.CalcularMedia());

            Console.ReadKey(); // comando para que ele não feche
        }
    }
}
