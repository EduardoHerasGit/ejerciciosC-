using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número del 1 al 9: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 1 || numero > 9)
        {
            Console.WriteLine("El número está fuera del rango (1-9).");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
