using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNegativoOcero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

            Console.ReadKey();
        }
    }
}
