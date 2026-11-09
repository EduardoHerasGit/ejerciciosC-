using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu estado civil abreviado (C, S, V o D): ");
        string entrada = Console.ReadLine().Trim().ToUpper();

        switch (entrada)
        {
            case "C":
                Console.WriteLine("Tu estado civil es Casad@");
                break;
            case "S":
                Console.WriteLine("Tu estado civil es Solter@");
                break;
            case "V":
                Console.WriteLine("Tu estado civil es Viud@");
                break;
            case "D":
                Console.WriteLine("Tu estado civil es Divorciad@");
                break;
            default:
                Console.WriteLine("Opción no válida. Debes introducir C, S, V o D.");
                break;
        }
    }
}
