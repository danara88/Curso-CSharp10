namespace _08_manejo_errores.Codigo
{
	/**
	 * 
	 * La clase base de todas las excepciones es Exception.
	 * 
	 * Es buena practica hacer un catch del le excepcion en especifico para mandar mensajes de error especificos.
	 * 
	 */
    public class CTryCatch
	{
		public static void CodigoDelCurso()
		{
			try
			{
				GetException();
			}
			catch(DivideByZeroException ex)
			{
                Console.WriteLine("Ha ocurrido una exception");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
			catch(NotImplementedException ex)
			{
				Console.WriteLine("Ha ocurrido una exception");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
			catch(Exception ex)
			{
				Console.WriteLine("Ha ocurrido una exception que no habi contemplado");
			}
			finally
			{
				// Este bloque se ejecuta si o si. Haya o no errores.
				Console.WriteLine("Este es el bloque del finally");
			}

			Console.WriteLine("Fin del programa");
		}

		public static void GetException()
		{
			Console.WriteLine("Lanzando la excepsion");
			throw new FileNotFoundException("EL archivo PDF no ha sido encontrado");
		}
	}
}

