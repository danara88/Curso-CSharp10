namespace _10_Modulo_Linq.Codigo
{
    public class MFuncionGroupBy
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

            var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);

            foreach (var grupo in agrupamientoPorSolteria)
            {
                // Van a ver dos grupos: Las personas con soltero = true y soletero = false
                Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");

                foreach (var persona in grupo)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }
        }
    }
}

