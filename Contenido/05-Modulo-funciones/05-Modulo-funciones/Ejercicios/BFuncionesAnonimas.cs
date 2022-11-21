namespace _05_Modulo_funciones.Ejercicios
{
    public class BFuncionesAnonimas
    {
        public void ImprimirSumaYMultiplicacion(int num1, int num2, int veces)
        {
            Func<int, int, int> sumar = (a, b) => a + b;

            Func<int, int, int> multiplicar = (a, b) => a * b;

            Action<int, int, int> imprimir = (suma, mult, veces) =>
            {
                for (int i = 0; i < veces; i++)
                {
                    Console.WriteLine($"{suma} - {mult}");
                }
            };

            imprimir(sumar(num1, num2), multiplicar(num1, num2), veces);

        }
    }
}
