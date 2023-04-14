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

Console.WriteLine($"Digite o tipo de combustivel: 'A' para alcool e 'G' para gasolina");
char tipoCombustivel = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Digite a quantidade de litros abastecida:");
float qtdLitros = float.Parse(Console.ReadLine());

float valorAPagar = CalcularValorAPagar(tipoCombustivel, qtdLitros);

if (valorAPagar > 0)
{
    Console.WriteLine($"O valor a ser pago é: {valorAPagar:F2}");
}

static float CalcularValorAPagar(char tipoCombustivel, float qtdLitros)
{
    float preçoGasolina = 5.30f;
    float preçoAlcool = 4.90f;
    float desconto = 0.0f;
    float preçoLitro = 0.0f;

    switch (tipoCombustivel)
    {
        case 'A':
            preçoLitro = preçoAlcool;
            if (qtdLitros <= 20)
            {
                desconto = 0.03f;
            }
            else
            {
                desconto = 0.05f;
            }
            break;
        case 'G':
            preçoLitro = preçoGasolina;
            if (qtdLitros <= 20)
            {
                desconto = 0.04f;
            }
            else
            {
                desconto = 0.06f;
            }
            break;
        default:
            Console.WriteLine($"Tipo de Combustivel invalido");
            return -1;
    }
    
    float valorSemDesconto = qtdLitros * preçoLitro;
    float valorComDesconto = valorSemDesconto * (1 - desconto);

    return valorComDesconto;

}















