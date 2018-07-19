using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: \n\n");
            string numero = Console.ReadLine();

            int num1 = Convert.ToInt32(numero);
            int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum = num1 * i;

                Console.WriteLine(num1 + " * " + i + " = " + sum);

                i++;
            }
        }
    }
}
