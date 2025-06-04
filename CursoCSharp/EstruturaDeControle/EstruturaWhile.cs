using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); // Gera um número entre 1 e 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;                   
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
                    Console.BackgroundColor = corAnterior;

                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior. Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("O número secreto é menor. Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
