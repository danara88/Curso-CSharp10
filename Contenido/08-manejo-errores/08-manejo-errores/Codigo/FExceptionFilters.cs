using System;
namespace _08_manejo_errores.Codigo
{
	public class FExceptionFilters
	{
		public static void CodigoDelCurso()
		{
			try
			{
				throw new MyCustomException(ErrorTipo.NotFoundError);
			}
			catch(MyCustomException ex) when (ex.errorTipo == ErrorTipo.ClientError)
			{
				Console.WriteLine("Error del cliente");
			}
            catch (MyCustomException ex) when (ex.errorTipo == ErrorTipo.ServerError)
            {
                Console.WriteLine("Error del servidor");
            }
            catch (MyCustomException ex) when (ex.errorTipo == ErrorTipo.NotFoundError)
            {
                Console.WriteLine("Recurso no encontrado");
            }
			Console.WriteLine("Fin del programa");
        }
	}

	/// <summary>
	/// Custom Exception
	/// </summary>
	public class MyCustomException : Exception
	{
		public ErrorTipo errorTipo { get; }

		public MyCustomException(ErrorTipo error) : base("Mensaje por defecto")
		{
			errorTipo = error;
		}

		public MyCustomException(ErrorTipo error, string? message) : base(message)
		{
			errorTipo = error;
		}
	}

	/// <summary>
	/// Tipos de error enumerador
	/// </summary>
	public enum ErrorTipo
	{
		ClientError,
		ServerError,
		NotFoundError
	}
}

