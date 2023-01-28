namespace _10_Modulo_Linq.Codigo
{
    public class IFuncionesEscalares
	{
		public static void CodigoDelCurso()
		{
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            // Conteo
            Console.WriteLine($"La cantidad de personas es {personas.Count()}");

            Console.WriteLine($"La cantidad de personas mayores a 30 es {personas.Count(p => p.Edad >= 30)}");

            Console.WriteLine($"El entero mas grande es {int.MaxValue.ToString("n")}");

            Console.WriteLine($"El long mas grande es {long.MaxValue.ToString("n")}");

            Console.WriteLine($"La cantidad de personas es {personas.LongCount()}");

            // Sumar
            var numeros = Enumerable.Range(1, 5);

            var suma = numeros.Sum();

            var sumaEdades = personas.Sum(p => p.Edad);

            // Minimo
            var minimo = numeros.Min();

            var edadMinima = personas.Min(p => p.Edad);

            // Maximo
            var maximo = numeros.Max();

            var edadMaxima = personas.Max(p => p.Edad);

            // Promedio

            var promedio = numeros.Average();

            var edadPromedio = personas.Average(p => p.Edad);
        }
    }
}

