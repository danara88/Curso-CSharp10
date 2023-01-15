using System;
namespace _08_manejo_errores.Codigo
{
	public class GRelanzandoExcepciones
	{
		public static void CodigoDelCurso()
		{
			RelanzandoException();
		}

		public static void RelanzandoException()
		{
			try
			{
				throw new Exception("Lanzando la excepcion");
			}
			catch(Exception)
			{
				Console.WriteLine("Procesando ....");
				throw;
			}
		}
	}
}

