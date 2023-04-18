// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

Console.WriteLine($"Digite o nome de usuário:");
string usuario = Console.ReadLine();

Console.WriteLine($"Digite a senha de acesso:");
string senha = Console.ReadLine();

Console.WriteLine($"Bem-vindo ao sistema {usuario}");

string[] nomes = new string[10];
float[] preco = new float[10];
bool[] estaEmPromocao = new bool[10];
int contador = 0;

while (true)
{
    Console.WriteLine(@$"
    ____________________________
    ║           MENU            ║
    ║                           ║
    ║    Selecione uma opção:   ║
    ║    1- Cadastrar produto   ║
    ║    2- Listar produtos     ║
    ║    0- Sair                ║
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
    ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        AdicionarProduto(ref nomes, ref preco, ref contador);
            break;

        case "2":
        ListarProdutos(nomes, preco, estaEmPromocao, contador);
            break;

        case "0":
            Console.WriteLine($"Encerrando programa.");
            return;

        default:
            Console.WriteLine($"Opção inválida.");
            break;
    }
}












static void ListarProdutos(string[] nomes, float[] preco, bool[] estaEmPromocao, int contador)
{
    if (contador == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
        return;
    }

    Console.WriteLine("Lista de produtos:");

    for (int i = 0; i < contador; i++)
    {
        float precoFinal = preco[i];
        estaEmPromocao[i] = preco[i] > 10;

        if (estaEmPromocao[i])
        {
            float desconto = preco[i] * 0.02f;
            float precoPromocional = preco[i] - desconto;
            precoFinal = precoPromocional;
        }

        Console.WriteLine($"Produto: {nomes[i]}, Preço: R${preco[i]}, Preço Final: {precoFinal:F2}");
    }
}

static void AdicionarProduto(ref string[] nomes, ref float[] preco, ref int contador)
{
    if (contador >= 10)
    {
        Console.WriteLine("Limite de produtos cadastrados atingido.");
        return;
    }

    Console.WriteLine($"Digite o nome do produto:");
    nomes[contador] = Console.ReadLine();

    Console.WriteLine($"Digite o preço do produto:");
    preco[contador] = float.Parse(Console.ReadLine());

    contador++;

    Console.WriteLine("Deseja cadastrar outro produto? (S/N)");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() == "N")
    {
        return;
    }
}



