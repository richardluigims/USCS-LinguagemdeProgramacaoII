using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Forms
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public bool Saca (double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor; // this.saldo = this.saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta(); // método button click
            c.numero = 1000;
            c.titular = "Paulo Souza";
            c.saldo = 2678.33;
            lblTitular.Text = c.titular;

            c.Sacar(678.33);
            lblSaldo.Text = c.saldo.ToString();
        }
    }
}
