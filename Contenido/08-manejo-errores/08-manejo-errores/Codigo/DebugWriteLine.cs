using System.Diagnostics;
using System.Text;

namespace _08_manejo_errores.Codigo
{
    /**
     * A en ocaciones queremos escribir en consola mensajes que solo aparezcan en desarrollo.
     * 
	 * Tenemos dos opciones de ambientes:
	 * 
	 * Debug: Configuracion que tenemos en tiempo de desarrollo.
	 * 
	 * Release: Modo optimo para ejecutar un programa (Su forma mas optima)
	 */
    public static class DebugWriteLine
	{
		public static void CodigoDelCurso()
		{
			var escritorConsole = new TextWriterTraceListener(System.Console.Out);

			var escritorPersonalizado = new TextWriterTraceListener(new EscritorPersonalizado());

			Trace.Listeners.Add(escritorConsole);

			Trace.Listeners.Add(escritorPersonalizado);

			Console.WriteLine("Esta linea se ha ejecutado");

			var cantidad = 8;

			Console.WriteLine($"El valor de la variable es { cantidad }");

			Debug.WriteLine("Este mensaje solo aparece en modo debug");
			
			int[] numeros = { 1, 2, 3, 4, 5 };

			foreach(int numero in numeros)
			{
				Console.WriteLine(numero);
			}
		}
	}

	/**
	 * Escritor personalizado
	 * 
	 */
    public class EscritorPersonalizado : TextWriter
    {
        public override Encoding Encoding => throw new NotImplementedException();

        public override void WriteLine(string? value)
        {
			Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")}");
        }
    }
}

