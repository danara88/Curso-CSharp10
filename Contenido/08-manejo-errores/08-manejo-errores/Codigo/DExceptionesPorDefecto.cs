namespace _08_manejo_errores.Codigo
{
    public class DExceptionesPorDefecto
	{
        public static void CodigoDelCurso()
        {
			// La base de todas las excepsiones.
			throw new Exception();

			// Cuando un metodo no ha sido implementada.
			throw new NotImplementedException();

			// Indica que el parametro o argumento de una funcion no es valido.
			throw new ArgumentException();

			// Se utiliza cuando los parametros de un metodo tiene valor nulo y no es valido.
			throw new ArgumentNullException();

			// Se utiliza cuando se divido entre cero, lo caul no es valido.
			throw new DivideByZeroException();

			// Se utiliza cuando no se ha encontrado un archivo en disco.
			throw new FileNotFoundException();

			// Se utiliza cuando el indice esta fuera de rango en un arreglo.
			throw new IndexOutOfRangeException();

			// Se usa cuando tenemos un casteo que no esta permitido.
			throw new InvalidCastException();

			// Se utiliza cuando accedemos a un miembro que puede ser nulo
			throw new NullReferenceException();

			// Cuando tenemos una operacion aritmetica que se pasa de la cantidad maxima que puede guardar un tipo de dato.
			throw new OverflowException();

			// Cuando tenemos referencias circulares entre metodos, haciendo un ciclo infinito.
			throw new StackOverflowException();
        }
    }
}

