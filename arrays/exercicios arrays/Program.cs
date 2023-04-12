string[] nomes = new string[5];
int[] idade = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira o nome da {i+1}º pessoa:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Insira a idade da {i+1}º pessoa :");
    idade[i] = int.Parse(Console.ReadLine());
}

for (var i = 0; i < 5; i++)
{
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine($"{i + 1}º Nome: {nomes[i]}");

    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"{i + 1}º Idade: {idade[i]} anos");
}

// using System;

// class Program {
//     static void Main(string[] args) {
//         string[] nomes = new string[5];
//         int[] idades = new int[5];
        
//         for (int i = 0; i < 5; i++) {
//             Console.Write("Digite o nome da {0}ª pessoa: ", i+1);
//             nomes[i] = Console.ReadLine();
//             Console.Write("Digite a idade da {0}ª pessoa: ", i+1);
//             idades[i] = int.Parse(Console.ReadLine());
//         }
        
//         Console.WriteLine("\nDados das pessoas cadastradas:");
//         for (int i = 0; i < 5; i++) {
//             Console.ForegroundColor = ConsoleColor.Blue;
//             Console.Write(nomes[i]);
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine(" - {0} anos", idades[i]);
//             Console.ResetColor();
//         }
//     }
// }
