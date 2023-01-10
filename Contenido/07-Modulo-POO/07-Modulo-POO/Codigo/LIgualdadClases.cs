using System;
namespace _07_Modulo_POO.Codigo
{
	public static class LIgualdadClases
	{
        public static void CodigoDelCurso()
        {
            var p1 = new PuntoClase(1, 2);
            var p2 = new PuntoClase(1, 3);

            var resultado = p1.Equals(p2);

            Console.Write(resultado);
        }
    }

    public class PuntoClase
    {
        public int X { get; }

        public int Y { get; }

        public PuntoClase(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(PuntoClase p1, PuntoClase p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(PuntoClase p1, PuntoClase p2)
        {
            return !(p1.X == p2.X && p1.Y == p2.Y);
        }

        public override bool Equals(object? obj)
        {
           if(obj is PuntoClase punto)
            {
                return this == punto;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}

