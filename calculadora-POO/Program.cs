using calculadora_POO;

while (true)
{
    Console.WriteLine(@"
▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠▬▬♠
◘       Bem vindo a calculadora 2.0     ◘
◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘▬◘
◘                                       ◘
◘  Selecione uma operação matematica:   ◘
◘                                       ◘
◘ '1' para somar                        ◘
◘ '2' para subtrair                     ◘
◘ '3' para multiplicar                  ◘
◘ '4' para dividir                      ◘
◘ '5' para sair da calculadora          ◘
◘                                       ◘
▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬▬▬╬
");

    string opcao = Console.ReadLine();

    if (opcao == "5")
    {
        Console.WriteLine($"Saindo...");
        break;
    }

    Console.WriteLine($"Digite dois numeros inteiros, ou quebrados:");
    float n1 = float.Parse(Console.ReadLine());
    float n2 = float.Parse(Console.ReadLine());

    Calculadora calculadora = new Calculadora();


    switch (opcao)
    {
        case "1":
            calculadora.Somar(n1, n2);
            Console.WriteLine($"O resultado da operação é {calculadora.Somar(n1, n2)}");
            break;
        case "2":
            calculadora.Subtrair(n1, n2);
            Console.WriteLine($"O resultado da operação é {calculadora.Subtrair(n1, n2)}");
            break;
        case "3":
            calculadora.Multiplicar(n1, n2);
            Console.WriteLine($"O resultado da operação é {calculadora.Multiplicar(n1, n2)}");
            break;
        case "4":
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine($"Não é possivel dividir por 0, ja que cujo o resultado é o mesmo");
            }
            else
            {
                calculadora.Dividir(n1, n2);
                Console.WriteLine($"O resultado da operação é {calculadora.Dividir(n1, n2)}");
            }

            break;
        case "5":
            Console.WriteLine($"Saindo");
            return;
        default:
            Console.WriteLine($"Opção invalida, tente novamente");
            break;
    }
}


