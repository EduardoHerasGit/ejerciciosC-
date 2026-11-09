using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 42, 7, 19, 3, 88, 15, 61, 27, 5, 34 };

        Array.Sort(numeros);

        Console.WriteLine("Valores ordenados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
