namespace _05_Modulo_funciones.Codigo
{
    public class EFuncionesParametrosOut
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1

            // Los parametros out deben estar definidas
            void DuplicarYTriplicar(int operando, out int resultadoDoble, out int resultadoTriple)
            {
                resultadoDoble = operando * 2;

                resultadoTriple = operando * 3;
            }

            int resultadoDoble, resultadoTriple;

            DuplicarYTriplicar(3, out resultadoDoble, out resultadoTriple);

            Console.WriteLine("El doble es: " + resultadoDoble);

            Console.WriteLine("El triple es: " + resultadoTriple);

        }
    }
}
