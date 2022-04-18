using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int qntdAlunos = 2;
            int qntdProf = 2;
            double[] media = new double[2];

            Professor[] prof = new Professor[qntdProf];

            for (i = 0; i < qntdProf; i++)
            {
                prof[i] = new Professor();

                Console.Write("Nome -- Professor {0}: ", i);
                prof[i].nome = (Console.ReadLine());
                Console.Write("Número de Cadastro -- Professor {0}: ", i);
                prof[i].SetNumeroCadastro (int.Parse(Console.ReadLine()));
                Console.Write("Sala de Aula -- Professor {0}: ", i);
                prof[i].SetSala(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            Aluno[] vet = new Aluno[qntdAlunos];

            for (i = 0; i < qntdAlunos; i++)
            {
                vet[i] = new Aluno();

                Console.Write("Nome -- Aluno {0}: ", i);
                vet[i].nome = (Console.ReadLine());
                Console.Write("Número da Chamada -- Aluno {0}: ", i);
                vet[i].numChamada = int.Parse(Console.ReadLine());
                Console.Write("P1 -- Aluno {0}: ", i);
                vet[i].p1 = double.Parse(Console.ReadLine());
                Console.Write("P2 -- Aluno {0}: ", i);
                vet[i].p2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (i = 0; i < qntdAlunos; i++)
            {
                media[i] = (vet[i].p1 + (vet[i].p2) * 2) / 3;
            }

            for (i = 0; i < qntdAlunos; i++)
            {
                Console.WriteLine("Média aluno {0}: {1}", i, Math.Round(media[i],2));
            }
        }
    }
}
