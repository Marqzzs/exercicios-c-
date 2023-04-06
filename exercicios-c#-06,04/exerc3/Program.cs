// 2. Faça um programa que receba a
// idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// ●      
// Total de Homens;

// ●      
// Total de Mulheres;

// ●      
// Média de idade dos Homens;

// ●      
// Média de idade das mulheres

int homens = 0;
int mulheres = 0;
int idadeHomens = 0;
int idadeMulheres = 0;


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite a sua idade:");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o seu peso:");
    float peso = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual o seu sexo, digite 'm' para mulher e 'h' para homem:");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    if (sexo == 'm')
    {
        mulheres++;
        idadeMulheres += idade;
    }
    else if (sexo == 'h')
    {
        homens++;
        idadeHomens += idade;
    }

    Console.WriteLine($"Total de Homens: {homens}");
Console.WriteLine($"Total de Mulheres: {mulheres}");

float mediaIdadeHomens = homens > 0 ? (float)idadeHomens / homens : 0;
Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens}");

float mediaIdadeMulheres = mulheres > 0 ? (float)idadeMulheres / mulheres : 0;
Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres}");

}

