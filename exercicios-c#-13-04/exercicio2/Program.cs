// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// faça um programa que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

class Program
{
    static void Main(string[] args)
    {
        // Preços dos combustíveis
        const double PRECO_ALCOOL = 4.90;
        const double PRECO_GASOLINA = 5.30;

        // Leitura dos dados de entrada
        Console.Write("Digite o número de litros vendidos: ");
        double litros = double.Parse(Console.ReadLine());
        Console.Write("Digite o tipo de combustível (A-álcool, G-gasolina): ");
        string tipoCombustivel = Console.ReadLine().ToUpper();

        // Cálculo do valor a ser pago
        double precoUnitario = tipoCombustivel switch
        {
            "A" => PRECO_ALCOOL,
            "G" => PRECO_GASOLINA,
            _ => throw new ArgumentException("Tipo de combustível inválido.")
        };

        double desconto = litros <= 20 ? 0.03 : 0.05;
        if (tipoCombustivel == "G")
        {
            desconto = litros <= 20 ? 0.04 : 0.06;
        }

        double valorTotal = litros * precoUnitario * (1 - desconto);

        // Impressão do valor a ser pago
        Console.WriteLine($"Valor a ser pago: R$ {valorTotal:F2}");
    }
}

// float preçoGasolina = 5.30;
// float totalAlcool;
// float totalGasolina;

// Console.Write("Digite o número de litros vendidos: ");
// float litros = float.Parse(Console.ReadLine());

// Console.Write("Digite o tipo de combustível (A-álcool, G-gasolina): ");
// string tipoCombustivel = Console.ReadLine().ToUpper();

// static float Desconto(float preçoAlcooL, float preçoGasolina)
// {
//     float precoUnitario = tipoCombustivel switch
//     {
//         "A" => preçoAlcooL,
//         "G" => preçoGasolina,
//         _ => throw new ArgumentException("Tipo de combustível inválido.")
//     };

//     double desconto = litros <= 20 ? 0.03 : 0.05;
//     if (tipoCombustivel == "G")
//     {
//         desconto = litros <= 20 ? 0.04 : 0.06;
//     }

//     double valorTotal = litros * precoUnitario * (1 - desconto);

//     // Impressão do valor a ser pago
//     Console.WriteLine($"Valor a ser pago: R$ {valorTotal:F2}");
//     return(totalAlcool,totalGasolina)

// }

// Console.WriteLine("$ O total é: {Desconto()}");













