using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoEmpleadoEmpresa final = new ManejoEmpleadoEmpresa();

            Console.WriteLine("Promedios por empresas \n********************************");
            final.promedioSalario();
            Console.WriteLine("");

            Console.WriteLine("Peces Gordos \n********************************");
            final.getCargo("CEO");

            Console.WriteLine("");
            Console.WriteLine("Plantilla \n********************************");
            final.getEmpleadosOrdenados();
            Console.WriteLine();
            Console.WriteLine("Plantilla ordenada por salario \n********************************");
            final.getEmpleadosOrdenadosSegun();

            Console.WriteLine("\nIngrese la empresa:(entero 1 a 3)\n1 para Stark Industries\n2 para Oscorp\n3 para Parker Industries");
            string Id = Console.ReadLine();
            try
            {

                int Empresa = int.Parse(Id);
                final.getEmpleadosEmpresa(Empresa);
            }
            catch {

                Console.WriteLine("Ha introducido un Id erroneo. Debe ingresar un numero entero");
            }
        }

        internal class Empleado
        {

            public int Ci { get; set; }
            public string Nombre { get; set; }
            public string Cargo { get; set; }
            public int Salario { get; set; }
            public int EmpresaId { get; set; }

            public void getDatosEmpleado()
            {


                Console.WriteLine("Empleado {0} con Ci {1}, con salario {3} y pertenece a " + "La empresa {4}", Nombre, Ci, Cargo, Salario, EmpresaId);
            }

        }

        internal class ManejoEmpleadoEmpresa
        {


            public List<Empresa> colEmpresa;
            public List<Empleado> colEmpleado;

            public ManejoEmpleadoEmpresa()
            {
                colEmpresa = new List<Empresa>();
                colEmpleado = new List<Empleado>();

                colEmpresa.Add(new Empresa { Id = 1, Nombre = "Stark Industries" });
                colEmpresa.Add(new Empresa { Id = 2, Nombre = "Oscorp" });
                colEmpresa.Add(new Empresa { Id = 3, Nombre = "Parker Industries" });

                colEmpleado.Add(new Empleado { Ci = 1, Nombre = "Rodrigo", Cargo = "CEO", EmpresaId = 1, Salario = 4000 });
                colEmpleado.Add(new Empleado { Ci = 2, Nombre = "Fernando", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
                colEmpleado.Add(new Empleado { Ci = 3, Nombre = "Manuel", Cargo = "Programador", EmpresaId = 1, Salario = 2500 });
                colEmpleado.Add(new Empleado { Ci = 4, Nombre = "Gonzalo", Cargo = "Desarrolador", EmpresaId = 1, Salario = 2001 });
                colEmpleado.Add(new Empleado { Ci = 5, Nombre = "Ana", Cargo = "CEO", EmpresaId = 2, Salario = 4500 });
                colEmpleado.Add(new Empleado { Ci = 6, Nombre = "Jose", Cargo = "CEO", EmpresaId = 3, Salario = 4000 });
                colEmpleado.Add(new Empleado { Ci = 7, Nombre = "Maria", Cargo = "CEO", EmpresaId = 1, Salario = 4000 });
                colEmpleado.Add(new Empleado { Ci = 8, Nombre = "JulianA", Cargo = "Desarrollador", EmpresaId = 2, Salario = 2500 });
                colEmpleado.Add(new Empleado { Ci = 9, Nombre = "RaulA", Cargo = "Desarrollador", EmpresaId = 3, Salario = 2400 });






            }

            public void getCargo(string Cargo)
            {

                IEnumerable<Empleado> empleados = from empleado in colEmpleado where empleado.Cargo == Cargo select empleado;

                foreach (Empleado elemento in empleados)
                {

                    elemento.getDatosEmpleado();
                }
            }

            public void getEmpleadosOrdenados()
            {

                IEnumerable<Empleado> empleados = from empleado in colEmpleado orderby empleado.Nombre select empleado;

                foreach (Empleado elemento in empleados)
                {

                    elemento.getDatosEmpleado();
                }
            }

            public void getEmpleadosOrdenadosSegun()
            {

                IEnumerable<Empleado> empleados = from empleado in colEmpleado orderby empleado.Salario select empleado;

                foreach (Empleado elemento in empleados)
                {

                    elemento.getDatosEmpleado();
                }
            }

            public void getEmpleadosEmpresa(int Empresa)
            {

                IEnumerable<Empleado> empleados = from empleado in colEmpleado join empresa in colEmpresa on empleado.EmpresaId equals empresa.Id where empresa.Id == Empresa select empleado;

                foreach (Empleado elemento in empleados)
                {

                    elemento.getDatosEmpleado();
                }
            }

            public void promedioSalario()
            {

                var consulta = from e in colEmpleado group e by e.EmpresaId into g select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };

                foreach (var resultado in consulta)
                {

                    switch (resultado.empresa)
                    {

                        case 1:
                            Console.WriteLine($"Empresa Stark Industries - Promedio de salario: {resultado.PromedioSalario}");
                            break;
                        case 2:
                            Console.WriteLine($"Empresa Oscorp - Promedio de salario: {resultado.PromedioSalario}");
                            break;
                        case 3:
                            Console.WriteLine($"Empresa Parker Industries - Promedio de salario: {resultado.PromedioSalario}");
                            break;
                    }

                }
            }
        }

        internal class Empresa
        {

            public int Id { get; set; }
            public string Nombre { get; set; }
            public void getDatoEmpresa()
            {

                Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
            }
        }
    }
}
