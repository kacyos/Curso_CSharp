using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.141516; // erro, pois PI é uma constante

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool verdade = true;
            Console.WriteLine("É verdade isso ?" + verdade);

            byte idade = 38; // vai de 0 a 256
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = -5; // vai de -127 a -128
            Console.WriteLine("Saldo de gols " + sbyte.MinValue);

            short salario = short.MaxValue; // vai de -32768 a 32767
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // vai de -2.147.483.648 a 2.147.483.647 
            Console.WriteLine("Menor valor de um int " + menorValorInt);

            uint populacao = 207_600_000; // vai de 0 a 4.294.967.295 /* pode colocar o undescore somente para dar clareza*/
            Console.WriteLine("População " + populacao);

            long menorValorLong = long.MinValue; // vai de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_000_000_000; // vai de 0 a 18.446.744.073.709.551.615
            Console.WriteLine("População mundial " + populacaoMundial);

            float preco = 1224.58f; // 7 dígitos de precisão
            Console.WriteLine("Preço registrado com float " + preco);

            double acao = 100_000.00; // 15 dígitos de precisão
            Console.WriteLine("Preço de uma ação com double " + acao);

            decimal valorMercado = 1_000_000_000_000.00m; // 28 dígitos de precisão
            Console.WriteLine("Valor de mercado com um decimal " + valorMercado);

            char letra = 'a'; // 2 bytes
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#"; // 2 bytes por caractere
            Console.WriteLine("Texto " + texto);
        }
    }
}
