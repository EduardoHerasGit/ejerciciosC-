using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número para calcular su factorial: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("El factorial no está definido para números negativos.");
            return;
        }
        if (numero > 20)
        {
            Console.WriteLine("El número es demasiado grande (máximo 20 para el tipo long).");
            return;
        }

        long factorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es {factorial}");
    }
}
