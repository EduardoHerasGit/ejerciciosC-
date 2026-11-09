using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        // Longitud
        Console.WriteLine($"Longitud: {texto.Length}");

        // Contiene una subcadena
        Console.Write("Introduce una subcadena a buscar: ");
        string subcadena = Console.ReadLine();
        Console.WriteLine($"¿Contiene \"{subcadena}\"?: {texto.Contains(subcadena)}");

        // Reemplazo de una letra por otra
        Console.Write("Letra a reemplazar: ");
        char letraVieja = Console.ReadLine()[0];
        Console.Write("Letra nueva: ");
        char letraNueva = Console.ReadLine()[0];
        Console.WriteLine($"Texto con reemplazo: {texto.Replace(letraVieja, letraNueva)}");

        // Mayúsculas y minúsculas
        Console.WriteLine($"En mayúsculas: {texto.ToUpper()}");
        Console.WriteLine($"En minúsculas: {texto.ToLower()}");

        // Eliminar un carácter en una posición determinada
        Console.Write($"Posición del carácter a eliminar (0 a {texto.Length - 1}): ");
        int posEliminar = int.Parse(Console.ReadLine());
        if (posEliminar >= 0 && posEliminar < texto.Length)
        {
            Console.WriteLine($"Texto sin ese carácter: {texto.Remove(posEliminar, 1)}");
        }
        else
        {
            Console.WriteLine("Posición no válida.");
        }

        // Subcadena indicando posición de inicio y fin
        Console.Write("Posición de inicio de la subcadena: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.Write("Posición de fin de la subcadena (incluida): ");
        int fin = int.Parse(Console.ReadLine());
        if (inicio >= 0 && fin < texto.Length && inicio <= fin)
        {
            Console.WriteLine($"Subcadena: {texto.Substring(inicio, fin - inicio + 1)}");
        }
        else
        {
            Console.WriteLine("Posiciones no válidas.");
        }
    }
}
