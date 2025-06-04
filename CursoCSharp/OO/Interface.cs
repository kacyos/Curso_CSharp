using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface IOperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>
       {
           new Soma(),
           new Subtracao(),
           new Multiplicacao()
       };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var operacao in operacoes)
            {
                resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);
        }
    }
}
