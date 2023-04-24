// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
using aluno_POO;
Aluno aluno = new Aluno();

Console.WriteLine(@$"
Escolha uma opção

'1' para ver a média
'2' para ver a média
'3' para ver a mensalidade

");

string opcao = Console.ReadLine();


switch (opcao)
{
    case "1":
    aluno.Cadastro();
        break;

    case "2":

        break;
    default:
        break;
}

