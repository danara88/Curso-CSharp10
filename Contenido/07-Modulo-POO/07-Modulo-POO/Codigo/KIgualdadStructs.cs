using System;
namespace _07_Modulo_POO.Codigo
{
	public static class KIgualdadStructs
	{
		public static void CodigoDelCurso()
		{
			var p1 = new Punto(1, 2);
			var p2 = new Punto(1, 4);

			var resultado = p1 == p2;

			Console.Write(resultado);
		}
	}

	public struct Punto
	{
		public int X { get; }

		public int Y { get; }

		public Punto(int x, int y)
		{
			X = x;
			Y = y;
		}

		public static bool operator ==(Punto p1, Punto p2)
		{
			return p1.X == p2.X && p1.Y == p2.Y;
		}

        public static bool operator !=(Punto p1, Punto p2)
        {
            return !(p1.X == p2.X && p1.Y == p2.Y);
        }

        public override bool Equals(object? obj)
        {
			return base.Equals(obj);
        }

        public override int GetHashCode()
        {
			return (X, Y).GetHashCode();
        }
    }
}

