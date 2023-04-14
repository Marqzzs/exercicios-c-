// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.
int[] valores = new int[10];

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Digite o {i+1}º valor: ", i+1);
    valores[i] = int.Parse(Console.ReadLine());
}

int maiorValor = valores[0];
int menorValor = valores[0];

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > maiorValor)
    {
        maiorValor = valores[i];
    }
    if (valores[i] < menorValor)
    {
        menorValor =  valores[i];
    }
}

Console.WriteLine($"Maior valor: {maiorValor}" );
Console.WriteLine($"Menor valor: {menorValor}" );


