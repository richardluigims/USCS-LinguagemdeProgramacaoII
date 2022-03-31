using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionário
{
    internal class Funcionario
    {
        private string nome;
        private int matricula;
        private double salario;

        public string GetNome()
        {
            return this.nome;
        }

        public int GetMatricula()
        {
            return this.matricula;
        }

        public double GetSalario()
        {
            return this.salario;
        }

        public void SetNome (string nome)
        {
            this.nome = nome;
        }

        public void SetMatricula (int matricula)
        {
            this.matricula = matricula;
        }

        public void SetSalario (double salario)
        {
            this.salario = salario;
        }
    }
}
