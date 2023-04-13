﻿// static float Somar(float n1, float n2)
// {
//  return (n1 + n2);
// }

// static float Dividir(float n1, float n2)
// {
//  return (n1 / n2);
// }

// static float Multiplicar(float n1, float n2)
// {
//  return (n1 * n2);
// }

// static float Subtrair(float n1, float n2)
// {
//  return (n1 - n2);
// }

// static void Carregamento(string texto, int pontinhos, int tempo)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.White;
//     Console.Write(texto);

//     for (var i = 0; i < pontinhos; i++)
//     {
//         Console.Write($".");
//         Thread.Sleep(tempo);
//     }
//     Console.ResetColor();
// }

// Console.WriteLine(@$"
//     Qual operação você deseja?
//     Digite os simbolos das operações para selecionar:
//     '+' para somar
//     '-' para subtrair
//     '*' para multiplicar
//     '/' para dividir
// ");
// char result = char.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o primeiro numero:");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo numero:");
// float n2 = float.Parse(Console.ReadLine());

// Carregamento("Carregando",8,500);
// switch (result)
// {
//     case '+':
//         Console.WriteLine($"A soma de {n1} + {n2} é: {Somar(n1,n2)}");
//         break;

//     case '-':
//         Console.WriteLine($"A subtração de {n1} - {n2} é: {Subtrair(n1,n2)}");
//         break;

//     case '*':
//         Console.WriteLine($"A multiplicação de {n1} * {n2} é: {Multiplicar(n1,n2)}");
//         break;

//     case '/':
//         Console.WriteLine($"A Divisção de {n1} / {n2} é: {Dividir(n1,n2)}");
//         break;
//     default:
//         Console.WriteLine($"Operação não encontrada!!");   
//         break;
// }

// if (result == '+')
// {
//     Console.WriteLine($"A soma de {n1} + {n2} é: {Somar(n1,n2)}");
// }
// if (result == '-')
// {
//     Console.WriteLine($"A subtração de {n1} - {n2} é: {Subtrair(n1,n2)}");
// }
// if(result == '*')
// {
//     Console.WriteLine($"A multiplicação de {n1} * {n2} é: {Multiplicar(n1,n2)}");
// }
// if(result == '/')
// {
//     Console.WriteLine($"A Divisção de {n1} / {n2} é: {Dividir(n1,n2)}");
// }

static float ImpostoRenda (float a)
{
    if (a <= 1500)
    {
        return 0;
    }
    else if (a > 1500 && a <= 3500 )
    {
        return a / 100 * 20;
    }
    else if (a > 3500 && a <= 6000 )
    {
        return a / 100 * 25;
    }
    else
    {
        return a / 100 * 35;
    }
}

Console.WriteLine($"Qual o seu salario?");
float salario = float.Parse(Console.ReadLine());

float imposto = ImpostoRenda(salario);

Console.WriteLine(@$"
Salario: ${salario}
Imposto: ${imposto}
");
