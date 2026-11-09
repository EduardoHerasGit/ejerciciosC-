using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el tamaño del array: ");
        int tamano = int.Parse(Console.ReadLine());

        if (tamano <= 0)
        {
            Console.WriteLine("El tamaño debe ser mayor que 0.");
            return;
        }

        int[] valores = new int[tamano];
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores pares:");
        foreach (int v in valores)
        {
            if (v % 2 == 0)
            {
                Console.WriteLine(v);
            }
        }

        Console.WriteLine("Valores impares:");
        foreach (int v in valores)
        {
            if (v % 2 != 0)
            {
                Console.WriteLine(v);
            }
        }
    }
}
