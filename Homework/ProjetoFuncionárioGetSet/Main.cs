using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double mediaSalarial;

            Funcionario[] vet = new Funcionario[4];

            for (i = 0; i < 4; i++)
            {
                vet[i] = new Funcionario();
            }

            vet[0].SetNome("Ricardo Santos");
            vet[0].SetMatricula(556677);
            vet[0].SetSalario(5000);

            vet[1].SetNome("André de Lima");
            vet[1].SetMatricula(456788);
            vet[1].SetSalario(2500);

            vet[2].SetNome("José Encapsulado");
            vet[2].SetMatricula(123456);
            vet[2].SetSalario(7000);

            vet[3].SetNome("Eduardo Limoeiro");
            vet[3].SetMatricula(445566);
            vet[3].SetSalario(9000);

            mediaSalarial = (vet[0].GetSalario() + vet[1].GetSalario() + vet[2].GetSalario() + vet[3].GetSalario()) / 4;

            Console.WriteLine("Funcionário com salário acima da média detectado!");

            for (i = 0; i < 4; i++)
            {
                if (vet[i].GetSalario() > mediaSalarial)
                {
                    Console.WriteLine("Seu nome é" + " " + vet[i].GetNome() + ", e seu número de matrícula é" + " " + vet[i].GetMatricula());
                }
            }   
        }
    }
}
