using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>() {




              new Persona { Nombre = "Manolo", Edad = 30, Ciudad = "Montevideo" },
              new Persona { Nombre = "Pepe", Edad = 20, Ciudad = "Lima" },
              new Persona { Nombre = "Rodrigo", Edad = 35, Ciudad = "Bogota" },
              new Persona { Nombre = "JuanCarlos", Edad = 65, Ciudad = "Madrid" },
              new Persona { Nombre = "Ana", Edad = 27, Ciudad = "Cordoba" },

        };

            var consulta1 = from p in personas where p.Edad > 30 && p.Ciudad == "Bogota" select new { p.Nombre };

            var consulta2 = from p in personas
                            where p.Edad > 25 && p.Edad < 35
                            orderby p.Edad ascending
                            select new { p.Nombre, p.Edad };

            foreach (var persona in consulta1)
            {

                Console.WriteLine($"i) {persona.Nombre}");
            }

            foreach (var persona in consulta2)
            {

                Console.WriteLine($"ii) {persona.Nombre}");


            }
        }
    }

    internal class Persona
    {


        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

    }
}