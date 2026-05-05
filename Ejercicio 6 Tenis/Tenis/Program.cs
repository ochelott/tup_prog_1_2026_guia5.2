using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;
            int SetJ1, SetJ2, SetGanadosJ1 = 0, setGanadosJ2 = 0; 
            Console.WriteLine("Ingrese el nombre del jugador 1:");
            nom1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2:");
            nom2 = Console.ReadLine();

            Console.WriteLine("Ingrese el puntaje del primer set del jugador 1:");
            SetJ1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el puntaje del primer set del jugador 2:");
            SetJ2 = Convert.ToInt32(Console.ReadLine());

            if (SetJ1 > SetJ2) 
            {
                SetGanadosJ1 = SetGanadosJ1 + 1;
            }
            else
                setGanadosJ2 = setGanadosJ2 + 1;

            Console.WriteLine("Ingrese el puntaje del segundo set del jugador 1:");
            SetJ1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el puntaje del segundo set del jugador 2:");
            SetJ2 = Convert.ToInt32(Console.ReadLine());

            if (SetJ1 > SetJ2)
            {
                SetGanadosJ1 = SetGanadosJ1 + 1;
            }
            else
                setGanadosJ2 = setGanadosJ2 + 1;

            Console.WriteLine("Ingrese el puntaje del tercer set del jugador 1:");
            SetJ1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el puntaje del tercer set del jugador 2:");
            SetJ2 = Convert.ToInt32(Console.ReadLine());

            if (SetJ1 > SetJ2)
            {
                SetGanadosJ1 = SetGanadosJ1 + 1;
            }
            else
                setGanadosJ2 = setGanadosJ2 + 1;

            if (SetGanadosJ1 > setGanadosJ2)
            {
                Console.WriteLine("GANADOR: " +  nom1); 
            }
            else
                Console.WriteLine("GANADOR: " +  nom2);

            Console.ReadKey();



            }
    }
}
