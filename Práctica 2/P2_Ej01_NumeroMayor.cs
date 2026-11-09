using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        // Una sola línea de WriteLine, sin concatenaciones
        Console.WriteLine($"Entre {a} y {b}, el mayor es {Math.Max(a, b)}");
    }
}
