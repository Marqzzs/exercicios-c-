// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.
// Use a estrutura condicional Switch Case.

Console.WriteLine(@$"
 _______________________
| BEM VINDO AO PROGRAMA |
| SELECIONE UMA BEBIDA  |
 -----------------------
");

Console.WriteLine(@$"
 _____________________________
|                             |
| Escolha a bebida desejada:  |
|                             |
-------------------------------
");
Console.WriteLine(@$"
_____________________________________
| Temos as opções:                   |
| Digite 1 para selecionar 'coca';   |
| Digite 2 para selecionar 'fanta';  |
| Digite 3 para selecionar 'dolly';  |
| Digite 4 para selecionar 'sukita'; |
-------------------------------------
");
char bebida = char.Parse(Console.ReadLine());

switch (bebida)
{
    case '1':
        Console.WriteLine($"Quer gelo adicional na coca?");
        string gelo = Console.ReadLine().ToLower();
        if (gelo == "sim")
        {
            Console.WriteLine($"Foi adicionado gelo adicional na coca");           
        }
        else
        {
            Console.WriteLine($"Sem gelo adicional na coca");           
        }
        break;
    case '2':
        Console.WriteLine($"Quer gelo adicional na fanta?");
        string gelo1 = Console.ReadLine().ToLower();
        if (gelo1 == "sim")
        {
            Console.WriteLine($"Foi adicionado gelo adicional na fanta");           
        }
        else
        {
            Console.WriteLine($"Sem gelo adicional na fanta");           
        }
        break;
    case '3':
        Console.WriteLine($"Quer gelo adicional no dolly?");
        string gelo2 = Console.ReadLine().ToLower();

        if (gelo2 == "sim")
        {
            Console.WriteLine($"Foi adicionado gelo adicional no dolly");           
        }
        else
        {
            Console.WriteLine($"Sem gelo adicional no dolly");           
        }
        break;    
    case '4':
        Console.WriteLine($"Quer gelo adicional na sukita?");
        string gelo3 = Console.ReadLine().ToLower();

        if (gelo3 == "sim")
        {
            Console.WriteLine($"Foi adicionado gelo adicional na sukita");           
        }
        else
        {
            Console.WriteLine($"Sem gelo adicional na sukita");           
        }
        break;
    default:
        Console.WriteLine($"Relaxa, teremos mais bebidas em breve!");  
        break;
}

Console.WriteLine(@$"
_______________________________________________________________________________
|                                                                              |
|  Seu pedido foi registrado e já está sempre preparado, aguarde no balcão ;)  |
|                                                                              |
--------------------------------------------------------------------------------
");





