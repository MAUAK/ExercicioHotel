using System;

namespace ExercicioHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um vetor com espaço de 10
            Estudante[] vect = new Estudante[10];

            //Imprimindo e lendo quantos números de estudantes alugarão os quadros
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            //Criando uma estrutura de repetição para declarar os hospedes e suas caracteristicas
            for (int i = 1; i <= n; i++)
            {
                //Pulando a linha
                Console.WriteLine();
                //Imprimindo os hospedes na tela com o número da repetição
                Console.WriteLine($"Hospede #{i}");
                //Pedindo e lendo o nome do hospede, e guardando na variavel nome da clase Estudante
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                //Pedindo e lendo o email do hospede, e guardando na variavel nome da clase Estudante
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                //Pedindo e lendo o quarto do hospede, e guardando em uma variavel  quarto
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                //Criando um vetor com o valor da variavel quarto e guardando junto na classe estudante
                vect[quarto] = new Estudante(nome, email);
            }

            //Pulando linha
            Console.WriteLine();
            //Imprimindo os quartos ocupados
            Console.WriteLine("Quartos ocupados: ");
            //Criando uma repetição para ver quantos quartos estão ocupados
            for (int i = 0; i < 10; i++)
            {
                //comparando se o número da repetição no vetor é diferente de nulo
                if (vect[i] != null)
                {
                    //Escrevendo o número do quarto junto com suas especificações (nome e email)
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
