﻿//2)Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Digite o placar do time-1");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o placar do time-2");
int time2 = int.Parse(Console.ReadLine());

if (time1 == time2)
{
    Console.WriteLine($"Empate");
}
else if (time1 > time2)
{
    Console.WriteLine($"vitoria time 1"); 
}
else
{
    Console.WriteLine($"Vitoria do time 2");
}

