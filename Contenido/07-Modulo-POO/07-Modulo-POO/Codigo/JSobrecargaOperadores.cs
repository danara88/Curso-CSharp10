using System;
namespace _07_Modulo_POO.Codigo
{
	public static class JSobrecargaOperadores
	{
		public static void CodigoDelCurso()
		{
			var vector1 = new Vector2D { X = 1, Y = 2 };
			var vector2 = new Vector2D { X = 3, Y = 4 };

			var vector3 = vector1 + vector2;

			var vectorV3 = vector1.Sumar(vector2);
		}
	}

	public class Vector2D
	{
		public int X { get; set; }

		public int Y { get; set; }

		public static Vector2D operator +(Vector2D v1, Vector2D v2)
		{
			return new Vector2D
			{
				X = v1.X + v2.X,
				Y = v1.Y + v2.Y
			};
		}

		public Vector2D Sumar(Vector2D v1)
		{
			return this + v1;
		}
    }
}

