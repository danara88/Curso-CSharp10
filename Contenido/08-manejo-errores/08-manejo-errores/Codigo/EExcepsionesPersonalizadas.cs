using System;
namespace _08_manejo_errores.Codigo
{
	public class EExcepsionesPersonalizadas
	{
		public static void CodigoDelCurso()
		{
			try
			{
				throw new CustomException("Mensaje insertado");
			}
			catch(CustomException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}

	public class CustomException : Exception
	{
		public CustomException() : base("Mensaje por defecto")
		{

		}

		public CustomException(string? message) : base(message) 
		{

		}
	}
}

