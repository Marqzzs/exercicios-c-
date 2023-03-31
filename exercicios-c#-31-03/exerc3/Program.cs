// 3)

// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Digite o raio da circunferencia:");
double raio = double.Parse(Console.ReadLine());
float pi = 3.14F;

Console.WriteLine($"O diametro da circunferencia e: {raio*2}, o comprimento e igual a:  {2*pi*raio}, e a area e equivalente a: {pi*raio*raio}");
