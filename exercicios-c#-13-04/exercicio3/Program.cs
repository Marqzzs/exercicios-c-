// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else


// Leitura dos dados de entrada
Console.Write("Digite a descrição do produto: ");
string descricao = Console.ReadLine();
Console.Write("Digite a quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine());
Console.Write("Digite o preço unitário: R$ ");
double precoUnitario = double.Parse(Console.ReadLine());

// Cálculo do total e do desconto

double total = quantidade * precoUnitario;
double desconto = 0.0;

if (quantidade <= 5)
{
    desconto = total * 0.02;
}
else if (quantidade <= 10)
{
    desconto = total * 0.03;
}
else
{
    desconto = total * 0.05;
}

// Cálculo do total a pagar
double totalAPagar = total - desconto;

// Impressão dos resultados
Console.WriteLine($"Produto: {descricao}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Preço unitário: R$ {precoUnitario:F2}");
Console.WriteLine($"Total: R$ {total:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Total a pagar: R$ {totalAPagar:F2}");

