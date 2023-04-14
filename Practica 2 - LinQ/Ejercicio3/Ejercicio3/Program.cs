using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //i) 
            
            Console.WriteLine("La Complejidad cognitiva del bloque es: 4");

            //ii)
            
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            valores = valores.OrderBy(valor => valor).ToList();

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }
        }


    }
}
