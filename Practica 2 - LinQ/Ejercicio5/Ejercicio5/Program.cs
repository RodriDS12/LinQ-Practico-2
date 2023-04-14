using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //i) 

            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach (var valor in valores)
            {

                if (valor % 2 == 0 && valor > 8)
                {

                    sumaTotalValoresParesMayoresAOcho += valor;

                }
                else if (valor % 2 == 0 && valor < 8)
                {

                    sumaTotalValoresParesMenoresAOcho += valor;

                }

            }

            Console.WriteLine($"La suma total de los valores pares mayores a 8 es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores pares mayores a 8 es: {sumaTotalValoresParesMenoresAOcho}");

            //ii) 

            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho2 = (from valor in valores2
                                                      where valor % 2 == 0 && valor > 8
                                                      select valor).Sum();

            int sumaTotalValoresParesMenoresAOcho2 = (from valor in valores2
                                                     where valor % 2 == 0 && valor < 8
                                                     select valor).Sum();

            Console.WriteLine($"La suma total de los valores pares mayores a 8 es: {sumaTotalValoresParesMayoresAOcho2}");
            Console.WriteLine($"La suma total de los valores pares mayores a 8 es: {sumaTotalValoresParesMenoresAOcho2}");
        }
    }
}
