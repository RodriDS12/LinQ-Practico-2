using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //i)
            
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumaTotal = valores.Sum();

            Console.WriteLine("La suma total es: " + sumaTotal);

            //ii)
            
            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumaTotalValoresPares = (from valor in valores2
                                         where valor % 2 == 0
                                         select valor).Sum();

            Console.WriteLine("La suma total de los valores pares es: " + sumaTotalValoresPares);

        }
    }
}
