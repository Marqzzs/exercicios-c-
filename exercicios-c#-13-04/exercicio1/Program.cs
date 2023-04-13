// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Qual o seu ano de nascimento?");
int nascimento = int.Parse(Console.ReadLine());

int anoATual = DateTime.Now.Year;
int result = anoATual - nascimento;

if (result < 16)
{
    Console.WriteLine($"Você ainda não pode votar");
}
else if (result >= 16)
{
    Console.WriteLine($"Você já pode votar");
}

