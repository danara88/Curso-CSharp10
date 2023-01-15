namespace _08_manejo_errores.Codigo
{
    public class BLanzandoErrores
	{
		public static void CodigoDelCurso()
		{
			Console.WriteLine("Antes del error");

			// Exception es la clase base de todas las Exceptions
			// throw new Exception(); // Lanzando una Exception manualmentee

			throw new NotImplementedException("Este metodo aun no ha sido implementado");

			// Depues del throw, nada se va a ejecutar

			Console.WriteLine("Despues del error");
		}
	}
}

