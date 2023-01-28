using System;
namespace _09_Modulo_Genericos.Codigo
{
	/**
	 * Una colección es un conjunto de valores que podemos guardar en una variable y que podemos recorrer.
	 * 
	 * Un arreglo es un tipo de colección, es un colección de tamaño fijo.
	 * 
	 * Una lista es un tipo de colección, el cual nos ayuda a no estar tan pendiente al tamaño de este, además tiene algunas funcionalidades.
	 */
	public class CListasColecciones
	{
		public static void CodigoDelCurso()
		{
			// Un arreglo es una colección con tamaño fijo
			int[] numbers = { 1, 2, 3, 4 };

			// Para añadir un nuevo elemento al arreglo es más tedioso
			// numbers.Add(2);

			// Una lista es un tipo de colección con ciertas funcionalidades para manipular la colección
			List<int> numbersList = new List<int>();

			// Otra forma de escribirlo
			List<int> numbersList2 = new List<int>() { 1, 2, 3 };

            // Otra forma de escribirlo
            List<int> numbersList3 = new() { 1, 2, 3 };

			numbersList.Add(1);

            numbersList.Add(2);

            numbersList.Add(3);

			// Con las listas puedo contar el total de elemtos
			int quanttity = numbersList.Count;

			// Puedo modificar los elementos por su índice
			numbersList[1] = 45;

			// Con las listas podemos ordenar los elmentos de menor a mayor
			numbersList.Sort();

			// Con las listas podemos eliminar un elemento
			numbersList.Remove(45);

			// Con las listas podemos eliminar elementos por su indice
			numbersList.RemoveAt(0);

			// Con las listas podemos borrar todos los elmentos.
			numbersList.Clear();

			Console.WriteLine();
        }
    }
}

