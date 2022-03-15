using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //classe vem antes do objeto 
            Aluno ric, and, gab, edu; // não é recomendável criar objetos com nomes, por conta da quantidade

            edu = new Aluno("Eduardo Limoeiro", 78, 9.8, 1.2);

            ric = new Aluno();
            ric.DefineNome("Richard Santos");
            ric.DefineIdade(32);
            ric.DefineP1(3.5);
            ric.DefineP2(8);

            Console.WriteLine(edu.PegaNome() + " " + edu.PegaIdade() + " " + edu.PegaP1() + " " + edu.PegaP2() + " " + edu.CalcularMedia());

            Console.WriteLine(ric.PegaNome() + " " + ric.PegaIdade() + " " + ric.PegaP1() + " " + ric.PegaP2() + " " + ric.CalcularMedia());

            Console.ReadKey(); // comando para que ele não feche
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aluno
{
    class Aluno // primeira letra maiúscula
    {
        private String nome; // escrever "public" para que a classe Main acesse Aluno
        private int idade;
        private double p1, p2, mediaFinal; // usar double para não precisar "f" no fim do valor

        public Aluno(string nome, int idade, double p1, double p2)
        {
            this.nome = nome;
            this.idade = idade;
            this.p1 = p1;
            this.p2 = p2;
        }

        public Aluno () { } // criar esse construtor porque o ric é diferente

        public string PegaNome ()
        {
            return this.nome;
        }

        public int PegaIdade ()
        {
            return this.idade;
        }

        public double PegaP1 ()
        {
            return this.p1;
        }

        public double PegaP2 ()
        {
            return this.p2;
        }

        public void DefineNome (String nome)
        {
            this.nome = nome;
        }

        public void DefineIdade (int idade)
        {
            this.idade = idade;
        }

        public void DefineP1 (double p1)
        {
            this.p1 = p1;
        }

        public void DefineP2 (double p2)
        {
            this.p2 = p2;
        }

        public double CalcularMedia()
        {
            double media = (this.p1 + this.p2) / 2; // para que cada um dos objetos tenha seus valores
            return media;
        }
    }
}
