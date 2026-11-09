using System;
using System.Collections;

class Program
{
    static void MostrarPila(Stack pila)
    {
        Console.WriteLine($"Contenido de la pila ({pila.Count} elementos):");
        foreach (object elemento in pila)
        {
            Console.WriteLine(elemento);
        }
    }

    static void Main()
    {
        Stack pila = new Stack();

        Console.Write("¿Cuántos valores quieres introducir en la pila?: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Introduce el valor entero {i}: ");
            pila.Push(int.Parse(Console.ReadLine()));
        }

        MostrarPila(pila);

        // Sacamos un par de elementos (los últimos introducidos)
        int sacados = Math.Min(2, pila.Count);
        for (int i = 0; i < sacados; i++)
        {
            Console.WriteLine($"Pop: {pila.Pop()}");
        }

        MostrarPila(pila);
    }
}
