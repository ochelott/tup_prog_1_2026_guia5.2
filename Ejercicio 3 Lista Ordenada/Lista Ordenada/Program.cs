using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ordenada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2, nom3 = "";
            int l1, l2, l3;
            Console.WriteLine("Ingrese los nombres de los tres alumnos:");
            nom1 = Console.ReadLine();
            nom2 = Console.ReadLine();
            nom3 = Console.ReadLine();
            Console.WriteLine("Ingrese los numero de las libretas de los tres alumnos:");
            l1 = Convert.ToInt32(Console.ReadLine());
            l2 = Convert.ToInt32(Console.ReadLine());
            l3 = Convert.ToInt32(Console.ReadLine());
            if (l1 < l2 && l2 < l3)
            {
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
            }

            else if (l2 < l1 && l1 < l3)
            {
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
            }
            else if (l2 < l3 && l3 < l1)
            {
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
            }
            else if (l3 < l2 && l2 < l1)
            {
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
            }

            else if (l1 < l3 && l3 < l2)
            {
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
            }

            else if (l3 < l1 && l1 < l2)
            {
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
            }

            else if (l1 < l3 && l3 < l2)
            {
                Console.WriteLine("Nombre del alumno: " + nom1 + " Numero de libreta: " + l1);
                Console.WriteLine("Nombre del alumno: " + nom3 + " Numero de libreta: " + l3);
                Console.WriteLine("Nombre del alumno: " + nom2 + " Numero de libreta: " + l2);
            }
            Console.ReadKey();
        }
    }
}
