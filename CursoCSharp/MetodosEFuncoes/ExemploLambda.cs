using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action escreverNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            escreverNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7); // Retorna um número aleatório entre 1 e 6
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = (numero) => numero.ToString("X"); // Converte o número para hexadecimal

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            {
                return string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            };

            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
