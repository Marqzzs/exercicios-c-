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
            if (contador >= 10)
            {
                Console.WriteLine("Limite de produtos cadastrados atingido.");
                break;
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
                break;
            }

            break;

        case "2":
            if (contador == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                break;
            }
            
            Console.WriteLine("Lista de produtos:");

            estaEmPromocao[contador] = preco[contador] > 10;

            for (int i = 0; i < contador; i++)
            {
                float precoFinal = preco[i];
                if (estaEmPromocao[i])
                {
                    float desconto = preco[i] * 0.02f;
                    float precoPromocional = preco[i] - desconto;
                    precoFinal = precoPromocional;
                }
                Console.WriteLine($"Produto: {nomes[i]}, Preço: R${preco[i]}, Preço Final: {precoFinal:F2}");
            }

            break;

        case "0":
            Console.WriteLine($"Encerrando programa.");
            return;

        default:
            Console.WriteLine($"Opção inválida.");
            break;
    }
}



