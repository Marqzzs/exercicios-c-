// 2)
// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"digite o primeiro numero:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o segundo numero:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o terceiro numero:");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2  )
{
    if (number1 > number3)
    {
        Console.WriteLine($"Number 1 é o maior");
    }
}
else if (number2 > number3)
{
    if (number2 > number1)
    {
        Console.WriteLine($"Number 2 é o maior");   
    }
}
else
{
    Console.WriteLine($"number 3 é o maior");
}

Console.WriteLine(Math.Min(number1, number2));
