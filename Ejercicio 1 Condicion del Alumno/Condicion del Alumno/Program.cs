using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicion_del_Alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, promedio;
            Console.WriteLine("Ingrese las notas de los 3 parciales: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            promedio = (n1 + n2 + n3) / 3;
            if (promedio > 7)
            {
                Console.WriteLine("Promociona");
            }
            else
            {
                Console.WriteLine("Rinde Final");
            }
            Console.ReadKey();
        }
            }
        }
