using System;
namespace _10_Modulo_Linq.Codigo
{
	public class NFuncionDistinctyDistinctBy
	{
        public static void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
            };

            int[] numeros = { 1, 1, 2, 3, 3, 4 };

            // Distinct: Elimina elemento duplicados en una coleccion
            var numerosSinRepeticion = numeros.Distinct();

            // DistinctBy: Aplicable para colecciones con objetos
            var personasSinRepeticion = personas.DistinctBy(p => p.Nombre);
        }
    }
}

