// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Digite um numero inteiro:");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
   Console.WriteLine($"{num} * {i} = {num * i}");
}

