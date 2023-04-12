int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um numero inteiro:");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"O dobro dos 5 numeros respectivamente são:");

foreach (var item in numeros)
{
    Console.WriteLine($"{item*2}");
}