namespace _10_Modulo_Linq.Codigo
{
    /**
     * 
     * Los cuantificadores universales nos permiten hacer pregutas tales como:
     * 
     * Son todas las personas de esta coleccion mayores de edad ?
     * Existe algun numero negativo en esta coleccion ?
     * 
     */
    public class KCuantificadoresUniversales
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

            // Cuantificador All: Hace una condicion si todos los elementos de una coleccion
            // cumplen con una caracteristica determinada.
            var sonTodasLasPersonasMayoresEdad = personas.All(p => p.Edad >= 18);

            // Cuantificador Any: Basta con al menos un elemento cumpla la condicion.
            var existePersonaMenorEdad = personas.Any(p => p.Edad <= 18);

            var personasMayor35 = personas.Any(p => p.Edad > 35);

            // Cuantificador Contains: Comprueba si un elemento es parte de una coleccion
            var numeros = Enumerable.Range(1, 5);

            var estaNumero3 = numeros.Contains(3);
        }
    }
}

