using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número gerado é {0}.", numero);

            for (int i = 0; i <= 50; i++)
            {
                Console.Write("{0} foi o número gerado? ", i);

                if (i == numero)
                {
                    var corAnterior = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine("Sim!");
                    Console.ForegroundColor = corAnterior;
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
