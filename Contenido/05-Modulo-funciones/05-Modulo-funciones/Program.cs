using _05_Modulo_funciones.Codigo;

using _05_Modulo_funciones.Ejercicios;

var objeto = new BFuncionesAnonimas();

objeto.ImprimirSumaYMultiplicacion(3, 4, 2);

// Recuperando argumentos de la consola
Console.WriteLine($"Recibiendo {args.Length} argumentos de la consola");

foreach(var arg in args)
{
    Console.WriteLine(arg);
}

return 40; // Cuando salimos de la aplicacion de consola retorna el numero.