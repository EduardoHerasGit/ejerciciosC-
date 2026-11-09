using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
        if (numero2 != 0)
        {
            Console.WriteLine($"La división es: {numero1 / numero2}");
            Console.WriteLine($"El módulo es: {numero1 % numero2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }
    }
}
