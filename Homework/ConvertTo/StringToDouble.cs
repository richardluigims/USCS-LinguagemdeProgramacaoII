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
            double x;
            string troca = "9,5";

            x = Convert.ToDouble(troca);
            
            Console.WriteLine("{0}", x);
        }
    }
}
