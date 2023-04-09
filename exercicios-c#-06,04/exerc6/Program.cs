// Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

string usuario, senha;

do
{
    Console.Write("Digite o nome de usuário: ");
    usuario = Console.ReadLine();

    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();

    if (usuario == senha)
    {
        Console.WriteLine("A senha não pode ser igual ao nome de usuário. Tente novamente.");
    }

} while (usuario == senha);

Console.WriteLine("Nome de usuário: " + usuario);
Console.WriteLine("Senha: " + senha);
