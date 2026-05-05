using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Año_bisiesto_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Ingrese un año: ");
            año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            Console.ReadLine();
        }
    }
}