// 6)Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.WriteLine($"Digite a frequencia do aluno:");
int frequencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a nota do primeiro bimestre:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do segundo bimestre:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do terceiro bimestre:");
int nota3 = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do terceiro bimestre:");
int nota4 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3 + nota4) / 4;

if (frequencia >= 75 && media >= 7)
{
    Console.WriteLine($"Aluno aprovado");
}

else if (75 >= frequencia && 7 > media)
{
Console.WriteLine($"aluno em recuperação");
}
else
{
    Console.WriteLine($"Aluno reprovado"); 
}