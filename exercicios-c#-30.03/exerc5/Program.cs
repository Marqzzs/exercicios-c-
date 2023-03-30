// 5)As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Digite o total de maçãs compradas");
int maçãs = int.Parse(Console.ReadLine());

float contaMenor = maçãs * 0.3f;
float contaMaior = maçãs * 0.25f;

if (maçãs >= 12)
{
    Console.WriteLine($"Total: R${contaMaior}");
}
else
{
    Console.WriteLine($"Total: R${contaMenor}");
}


