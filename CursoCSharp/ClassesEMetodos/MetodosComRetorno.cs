using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosComRetorno
    {
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public double Dividir(double a, double b)
            {
                if (b == 0)
                {
                    throw new ArgumentException("Divisão por zero não é permitida.");
                }
                return a / b;
            }
        }

        class CalculadoraCadeia
        {
            int _memoria;

            public CalculadoraCadeia Somar(int valor)
            {
                _memoria += valor;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int valor)
            {
                _memoria *= valor;
                return this;
            }

            public CalculadoraCadeia Subtrair(int valor)
            {
                _memoria -= valor;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                _memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(_memoria);
                return this;
            }

            public int Resultado()
            {
                return _memoria;
            }
        }

        public static void Executar()
        {
           var calculadoreComum = new CalculadoraComum();

            Console.WriteLine(calculadoreComum.Somar(10, 5));
            Console.WriteLine(calculadoreComum.Subtrair(10, 5));
            Console.WriteLine(calculadoreComum.Multiplicar(10, 5));
            Console.WriteLine(calculadoreComum.Dividir(2, 7));

            Console.WriteLine("Calculadora Cadeia");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia
                .Somar(3)
                .Multiplicar(2)
                .Subtrair(1)
                .Imprimir()
                .Limpar()
                .Imprimir();
        }
    }
}
