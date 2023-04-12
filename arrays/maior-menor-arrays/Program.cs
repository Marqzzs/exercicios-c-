using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê um array de números inteiros
        Console.WriteLine("Digite os números separados por espaço:");
        string input = Console.ReadLine();
        string[] stringNumeros = input.Split(' ');
        int[] numeros = new int[stringNumeros.Length];
        for (int i = 0; i < stringNumeros.Length; i++)
        {
            numeros[i] = int.Parse(stringNumeros[i]);
        }

        // Encontra o maior e o menor valor do array
        int maior = numeros[0];
        int menor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        // Imprime o resultado
        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
    }
}

