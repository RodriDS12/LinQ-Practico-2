using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //i 

            Console.WriteLine("La complejidad cognitiva es de: 6");


            //ii) 

            
            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario!"); ;
            
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "b" || letra == "c" || letra == "d" || letra == "e" || letra == "f")
            {
                Console.WriteLine($"La siguiente letra del abecedario es {(char)(letra[0] + 1)}.");
            }
            
            else
            {
                Console.WriteLine("La letra ingresada no es válida.");
            }
        }
    }
}
