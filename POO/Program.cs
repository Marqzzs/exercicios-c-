// Exercício:
// Crie 5 classes com 3 objetos diferentes em cada, usando propostas diferentes das que foram passadas em aula, utilizando objetos do mundo real.

// Ex:
// Classe: Cadeira 
// Características: Pernas, Estofado, Cor... 
// Comportamento: Abaixar assento, girar... 
// Objeto: Cadeira de escritório 
// Objeto: Cadeira de balanço 
// Objeto: Cadeira gamer

class Pessoa
{
    string nome;
    string altura;
    string raca;


    void andar()
    {
        Console.WriteLine($"A pessoa andou");
    }

    void falar()
    {
        Console.WriteLine($"A pessoa falou");
    }

    static void Main(string[] args)
    {
        Pessoa Americana = new Pessoa();
        Americana.nome = "Josh";
        Americana.altura = "1,60";
        Americana.raca = "Branco";

        Pessoa Africana = new Pessoa();
        Americana.nome = "Ezera";
        Americana.altura = "1,80";
        Americana.raca = "Negro";

        Pessoa Brasileira = new Pessoa();
        Americana.nome = "Gustavo";
        Americana.altura = "1,75";
        Americana.raca = "Pardo";
    }
}

class Filme
{
    string genero;
    string duração;

    void Entreter()
    {
        Console.WriteLine($"O filme entreteu");
    }

    void Gastar()
    {
        Console.WriteLine($"Te fez gastar com aquela pipoquinha");
    }

    static void Main(string[] args)
    {
        Filme Invocação = new Filme();
        Invocação.genero = "Terror";
        Invocação.duração = "2:41";

        Filme OsIncriveis = new Filme();
        Invocação.genero = "Animação";
        Invocação.duração = "2:12";

        Filme TaChovendoHamburguer = new Filme();
        Invocação.genero = "Animação";
        Invocação.duração = "1:47";
    }
}

class Celular
{
    string modelo;
    string tela;
    string processador;


    void ligar()
    {
        Console.WriteLine($"Ligou");
    }

    void desligar()
    {
        Console.WriteLine($"Desligou");
    }

    void notificar()
    {
        Console.WriteLine($"Olha o zapzap");
    }

    static void Main(string[] args)
    {
        Celular iphone = new Celular();
        iphone.modelo = "12pro";
        iphone.tela = "6.4";
        iphone.processador = "aBionic15";

        Celular xiaomi = new Celular();
        iphone.modelo = "pocof3";
        iphone.tela = "6.7";
        iphone.processador = "snapdragon875";

        Celular sansung = new Celular();
        iphone.modelo = "s20fe";
        iphone.tela = "6.5";
        iphone.processador = "snapdragon870";
    }
}

class Carros
{
    string modelo;
    string motor;
    string escapamento;


    void ligar()
    {
        Console.WriteLine($"Ligou");
    }

    void desligar()
    {
        Console.WriteLine($"Desligou");
    }

    void acelerar()
    {
        Console.WriteLine($"O carro acelerou");
    }

    static void Main(string[] args)
    {
        Carros opala = new Carros();
        opala.modelo = "74";
        opala.motor = "motor 6cl";
        opala.escapamento = "esportivo";

        Carros subaru = new Carros();
        opala.modelo = "imprenza";
        opala.motor = "jdx";
        opala.escapamento = "esportivo";

        Carros rxm = new Carros();
        opala.modelo = "mazda";
        opala.motor = "jdx";
        opala.escapamento = "esportivo";
    }
}

class Computador
{
    string modelo;
    string processador;



    void ligar()
    {
        Console.WriteLine($"Ligou");
    }

    void desligar()
    {
        Console.WriteLine($"Desligou");
    }

    static void Main(string[] args)
    {
        Computador Amd = new Computador();
        Amd.modelo = "Amd";
        Amd.processador = "ryzen9 5950x";

        Computador MAC = new Computador();
        MAC.modelo = "MAC";
        MAC.processador = "Apple M1";

        Computador Intel = new Computador();
        Intel.modelo = "Intel";
        Intel.processador = "i12";
    }
}

