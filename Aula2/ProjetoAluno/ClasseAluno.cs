using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    class Aluno // primeira letra maiúscula
    {
        public String nome; // escrever "public" para que a classe Main acesse Aluno
        public int idade;
        public double p1, p2, mediaFinal; // usar double para não precisar "f" no fim do valor

        public double CalcularMedia ()
        {
            double media = (this.p1 + this.p2) / 2; // para que cada um dos objetos tenha seus valores
            return media;
        }
    }
}
