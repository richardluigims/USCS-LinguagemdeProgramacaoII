using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    public abstract class Funcionario
    {
        // estas propriedades valerão para todas classes derivadas
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        // este método valerá para todas classes derivadas
        public void Mostra_funcionario()
        {
            Console.WriteLine("Matrícula: {0} - Nome: {1}", this.Matricula, this.Nome);
        }
        // este método será abstrato e deve ser declarado nas classes derivadas
        public abstract double Reajuste();
    }
}
