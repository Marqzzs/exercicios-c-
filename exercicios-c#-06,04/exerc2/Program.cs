// 1. Uma certa empresa fez uma
// pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// os homens analisados.


int sim = 0;
int nao = 0;
int mulheressim = 0;
int homenssim = 0;
int mulheresnao = 0;
int homensnao = 0;
int homens = 0;


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Qual o seu sexo, digite 'm' para mulher e 'h' para homem:");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine(@$"O que achou do mais novo lançamento da empresa X?
    Digite 's' para sim e 'n' para não");
    char resposta = char.Parse(Console.ReadLine().ToLower());

    if (resposta == 's')
    {
        sim++;
    }
    else
    {
        nao++;
    }

    if (sexo == 'm' && resposta == 's')
    {
        mulheressim++;
    }

    if (sexo == 'h')
    {
        homens++;

        if (resposta == 'n')
        {
            homensnao++;
        }

        if (sexo == 'h' && resposta == 's')
        {
            homenssim++;
        }
    
    }

     Console.WriteLine($"Número de pessoas que responderam SIM: {sim}");
        Console.WriteLine($"Número de pessoas que responderam NÃO: {nao}");
        Console.WriteLine($"Número de mulheres que responderam SIM: {mulheressim}");

        if (homens == 0) {
            Console.WriteLine("Não houve homens analisados.");
        } else {
            float porcentagemHomensNao = (float)homensnao / homens * 100;
            Console.WriteLine($"Porcentagem de homens que responderam NÃO: {porcentagemHomensNao}%");
        }

}