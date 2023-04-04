using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma letra: ");
        char letra = Console.ReadKey().KeyChar;

        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
            letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
        {
            Console.WriteLine("\nA letra digitada é uma vogal!");
        }
        else
        {
            Console.WriteLine("\nA letra digitada é uma consoante!");
        }

        Console.ReadKey();
    }
}
