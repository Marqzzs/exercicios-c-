//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Digite seu nome: (Não pode conter algum caractere vazio)");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade: (0 - 100)");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu salario: (Tem que ser maior que zero)");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine(@$"
E o seu estado civil:
's' para solteiro
'c' casado
'v' viuvo
'd' divorciado
");
char civil = char.Parse(Console.ReadLine());


while (nome == "")
{
    Console.WriteLine($"Digite um nome por gentileza");
    nome = Console.ReadLine();
}

while (idade > 100)
{
    Console.WriteLine($"Rainha Elizabeth és tú:");
    Console.WriteLine($"Digite novamente");
    idade = int.Parse(Console.ReadLine());
}

while (salario == 0)
{
    Console.WriteLine($"Digite o salario correto");
    salario = float.Parse(Console.ReadLine());
}


while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.WriteLine($"digite um estado civil valido");
    civil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Dados validados");







