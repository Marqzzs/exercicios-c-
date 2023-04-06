
Console.WriteLine($"Qual a idade do pericles");
int idade = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"Digite novamente a idade até acertar:");
    idade = int.Parse(Console.ReadLine());
} while (idade != 53);


