// FUNÇÕES

//CRIANDO UM METODO

//STATIC = PQ O METODO ESTA DENTRA DA CLASSE PROGRAM.CS, 

//CRIAR UM METODO QUE DE BOM DIA

// static void Sauda()
// {
//     Console.WriteLine($"Qual o nome da pessoa:");
//     string nome = Console.ReadLine();
    
//     Console.WriteLine($"Qual o sobrenome da pessoa:");
//     string sobre = Console.ReadLine();
    
//     Console.WriteLine($"Bom dia {nome} {sobre}!");
// }

// Sauda();

//criar um metodo para somar dois numeros

// static float Somar(float n1, float n2)
// {
//  return (n1 + n2);
// }

// static float Dividir(float n1, float n2)
// {
//  return (n1 / n2);
// }

// static float Multiplicar(float n1, float n2)
// {
//  return (n1 * n2);
// }

// static float Subtrair(float n1, float n2)
// {
//  return (n1 - n2);
// }

// static void Carregamento(string texto, int pontinhos, int tempo)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.White;
//     Console.Write(texto);

//     for (var i = 0; i < pontinhos; i++)
//     {
//         Console.Write($".");
//         Thread.Sleep(tempo);
//     }
//     Console.ResetColor();
// }

// Console.WriteLine(@$"
//     Qual operação você deseja?
//     Digite os simbolos das operações para selecionar:
//     '+' para somar
//     '-' para subtrair
//     '*' para multiplicar
//     '/' para dividir
// ");
// char result = char.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o primeiro numero:");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo numero:");
// float n2 = float.Parse(Console.ReadLine());

//Carregamento("Carregando",8,500);
// switch (result)
// {
//     case '+':
//         Console.WriteLine($"A soma de {n1} + {n2} é: {Somar(n1,n2)}");
//         break;
    
//     case '-':
//         Console.WriteLine($"A subtração de {n1} - {n2} é: {Subtrair(n1,n2)}");
//         break;
    
//     case '*':
//         Console.WriteLine($"A multiplicação de {n1} * {n2} é: {Multiplicar(n1,n2)}");
//         break;

//     case '/':
//         Console.WriteLine($"A Divisção de {n1} / {n2} é: {Dividir(n1,n2)}");
//         break;
//     default:
//         Console.WriteLine($"Operação não encontrada!!");   
//         break;
// }

// if (result == '+')
// {
//     Console.WriteLine($"A soma de {n1} + {n2} é: {Somar(n1,n2)}");
// }
// if (result == '-')
// {
//     Console.WriteLine($"A subtração de {n1} - {n2} é: {Subtrair(n1,n2)}");
// }
// if(result == '*')
// {
//     Console.WriteLine($"A multiplicação de {n1} * {n2} é: {Multiplicar(n1,n2)}");
// }
// if(result == '/')
// {
//     Console.WriteLine($"A Divisção de {n1} / {n2} é: {Dividir(n1,n2)}");
// }

//Função para mostrar a hora
// static int Hora()
// {
//     return DateTime.Now.Hour;
// }

// Console.WriteLine(Hora());

//tela de carregamento

