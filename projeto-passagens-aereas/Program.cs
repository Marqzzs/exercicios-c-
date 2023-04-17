// // Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// // Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// // O sistema deve exibir um menu com as seguintes opções:

// // 1- Cadastrar passagem
// // 2- Listar Passagens
// // 0- Sair


// // Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

Console.WriteLine("Digite o usuario:");
string usuario = Console.ReadLine();

Console.WriteLine("Digite a senha de acesso:");
string senha = Console.ReadLine();

if (senha != "123456")
{
    Console.WriteLine("Senha incorreta. Acesso negado.");
    return;
}

Console.WriteLine($"Bem vindo {usuario}");


string[] nomes = new string[5];
string[] origens = new string[5];
string[] destinos = new string[5];
string[] datas = new string[5];
int contador = 0;

while (true)
{
    Console.WriteLine(@$"
    ____________________________
    ║           MENU            ║
    ║                           ║
    ║    Selecione uma opção:   ║
    ║    1- Cadastrar passagem  ║
    ║    2- Listar Passagens    ║
    ║    0- Sair                ║
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
    ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do passageiro:");
            nomes[contador] = Console.ReadLine();

            Console.WriteLine("Digite a origem do voo:");
            origens[contador] = Console.ReadLine();

            Console.WriteLine("Digite o destino do voo:");
            destinos[contador] = Console.ReadLine();

            Console.WriteLine("Digite a data do voo (DD/MM/AAAA):");
            datas[contador] = Console.ReadLine();

            contador++;

            Console.WriteLine("Deseja cadastrar outra passagem? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "N")
            {
                break;
            }

            if (contador >= 5)
            {
                Console.WriteLine("Limite de passagens cadastradas atingido.");
                break;
            }
            break;

        case "2":
            if (contador == 0)
            {
                Console.WriteLine("Nenhuma passagem cadastrada.");
                break;
            }

            Console.WriteLine("Lista de passagens:");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Passageiro: {nomes[i]}, Origem: {origens[i]}, Destino: {destinos[i]}, Data: {datas[i]}");
            }

            break;

        case "0":
            Console.WriteLine("Encerrando o programa...");
        return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
























