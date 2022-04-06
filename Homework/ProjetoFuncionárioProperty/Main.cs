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
            int i;
            double mediaSalario;
            int qntdFuncionarios = 4;

            Funcionario[] vet = new Funcionario[4];

            for (i = 0; i < qntdFuncionarios; i++)
            {
                vet[i] = new Funcionario();
            }

            vet[0].nome = "Sérgio Lopez";
            vet[0].matricula = 34560;
            vet[0].salario = 1098.80;

            vet[1].nome = "Silvia de Sal";
            vet[1].matricula = 12345;
            vet[1].salario = 1627.28;

            vet[2].nome = "André Santos";
            vet[2].matricula = 78923;
            vet[2].salario = 7436.10;

            vet[3].nome = "Richard Aluno";
            vet[3].matricula = 89123;
            vet[3].salario = 5492.45;

            mediaSalario = (vet[0].salario + vet[1].salario + vet[2].salario + vet[3].salario) / 4;

            for (i = 0; i < qntdFuncionarios; i++)
            {
                if (vet[i].salario > mediaSalario)
                {
                    Console.WriteLine("Salário acima da média: {0} -- {1}", vet[i].nome, vet[i].matricula);
                }
            }
        }
    }
}
