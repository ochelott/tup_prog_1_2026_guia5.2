using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayorValor;
            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            mayorValor = num;
            Console.WriteLine("Ingrese otro número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayorValor)
            {
                mayorValor = num;
            }
            Console.WriteLine("Ingrese otro número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayorValor)
            {
                mayorValor = num;
            }
            Console.WriteLine("Ingrese otro número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayorValor)
            {
                mayorValor = num;
            }
            Console.WriteLine("Ingrese otro número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayorValor)
            {
                mayorValor = num;
            }
            Console.WriteLine("El mayor valor es: " + mayorValor);
           
            Console.ReadKey();







        }
    }
}
