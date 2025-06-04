using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é: {totalDesconto}");

            //IMC
            double peso = 70;
            double altura = 1.70;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("IMC é: {0}", imc);

            //Número Par ou Ímpar
            int par = 24;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
