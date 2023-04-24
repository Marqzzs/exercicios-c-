using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aluno_POO
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string idade;
        public string rg;
        public bool bolsista;
        public string media;
        public float mensalidade = 300f;


        public void Cadastro()
        {
            Console.WriteLine($"Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine($"Digite o curso:");
            curso = Console.ReadLine();

            Console.WriteLine($"Digite a idade:");
            idade = Console.ReadLine();

            Console.WriteLine($"Digite o rg:");
            rg = Console.ReadLine();

            Console.WriteLine($"Digite a média do aluno:");
            media = Console.ReadLine();

            do
            {
                Console.WriteLine($"O aluno é bolsista? S/N");
                bolsista == 
            } while (false);


        }
        public void VerMediaFinal()
        {
            Console.WriteLine($"A media final é {media}");
        }

        public void VerMensalidade()
        {
            Console.WriteLine($"O valor da mensalidade é: {mensalidade}");

        }

        public float CalcularMensalidade()
        {

        }


    }
}
