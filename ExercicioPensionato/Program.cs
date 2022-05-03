using System;

namespace ExercicioPensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int numeroQuartos = int.Parse(Console.ReadLine());

            if (numeroQuartos < 0 || numeroQuartos > 9)
            {
                Console.WriteLine("\nNeste pensionato há disponibilidade de apenas 10 quartos.");
            }
            else
            {
                for (int i = 1; i <= numeroQuartos; i++)
                {
                    Console.WriteLine($"\nAluguel #{i}:");
                    Console.Write("Nome do estudante: ");
                    string nome = Console.ReadLine();
                    Console.Write("Email do estudante: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto desejado: ");
                    int quarto = int.Parse(Console.ReadLine());
                    vetor[quarto] = new Estudante(nome, email);

                    Console.WriteLine("\nQuartos ocupados:");
                    for (int a = 0; a < 10; a++)
                    {
                        if (vetor[a] != null)
                        {
                            Console.WriteLine(a + ": " + vetor[a]);
                        }
                    }
                }
            }
        }
    }
}