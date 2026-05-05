using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_que_ocurrio_el_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, orden, menor;
            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            orden = 1;
            menor = num;
            Console.WriteLine("Ingrese otro numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                orden = 2;
            }
            Console.WriteLine("Ingrese otro numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                orden = 3;
            }
            Console.WriteLine("Ingrese otro numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                orden = 4;
            }
            Console.WriteLine("Ingrese otro numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                orden = 5;
            }
            Console.WriteLine("El numero menor es: " + menor);
            Console.WriteLine("El orden en que ocurrio el numero menor es: " + orden);
        }
    }
}
