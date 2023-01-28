namespace _10_Modulo_Linq.Codigo
{
    public class LFuncionTakeSkip
	{
		public static void CodigoDelCurso()
		{
			var numeros = Enumerable.Range(1, 100);

			var primeros10Numeros = numeros.Take(10).ToList();

			var ultimos10Numeros = numeros.TakeLast(10).ToList();

			var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

			var penultimoLoteDe10 = numeros.SkipLast(10).TakeLast(10).ToList();
		}
	}
}

