using System;

class Program
{
    static void Main()
    {
        // ASCII: Z = 90, A = 65
        for (int codigo = 90; codigo >= 65; codigo--)
        {
            string letra = Convert.ToString((char)codigo);
            Console.Write(letra + " ");
        }
        Console.WriteLine();
    }
}
