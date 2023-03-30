//3)Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"Digite a medida do lado 1:");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a medida do lado 2:");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a medida do lado 3: (o lado igual ou diferente)");
int lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"Triangulo Equilatero");
}
else if (lado1 == lado2 && lado2 != lado3)
{
    Console.WriteLine($"Triangulo isosceles");
}
else
{
    Console.WriteLine($"Triangulo escaleno");
}



