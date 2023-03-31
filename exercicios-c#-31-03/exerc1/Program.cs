// 1) 
// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Qual o dia do seu aniversario?");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o mes do seu aniversario?");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o ano do seu aniversario?");
int ano = int.Parse(Console.ReadLine());

if (1 >= dia || mes <= 12)
{

}
if (2013 >= ano)
{
    Console.WriteLine($"data confirmada");
    
}
else
{
    Console.WriteLine($"data invalida");
}