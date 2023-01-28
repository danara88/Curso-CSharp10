using System;
namespace _10_Modulo_Linq.Codigo
{
    public class CFuncionWhere
    {
        public static void CodigoDelCurso()
        {
            // Ejemplo 1

            int[] numbers = Enumerable.Range(1, 5).ToArray();

            // Where y AND
            var peerNumbers = numbers.Where(x => x % 2 == 0 && x > 2).ToList();

            // Ejemplo 2
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            var personas25omenos = personas.Where(p => p.Edad <= 25).ToList();

            var solteros = personas.Where(p => p.Soltero).ToList();

            var fechaActual = DateTime.Today;

            // Personas que entraron a la empresa hace menos de 3 meses
            var personasConMenos3mesesEnEmpresa = personas.Where(p => p.FechaIngresoALaEmpresa >= fechaActual.AddMonths(-3)).ToList();

        }
    }

    public class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public DateTime FechaIngresoALaEmpresa { get; set; }

        public bool Soltero { get; set; }
    }
}

