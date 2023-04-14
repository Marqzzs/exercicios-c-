// Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

int[] numeros = new int[15];

// Lê os números e armazena no vetor
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// Exibe os números em ordem inversa
Console.WriteLine("Números em ordem inversa:");
for (int i = 14; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}
