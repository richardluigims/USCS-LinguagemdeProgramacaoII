using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Gerente : Funcionario
    {
        public override double Reajuste()
        {
            this.Salario += 2500;
            return this.Salario;
        }
    }
}
