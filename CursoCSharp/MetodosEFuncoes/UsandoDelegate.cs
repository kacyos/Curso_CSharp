using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double Somar(double a, double b)
        {
            return a + b;
        }

        static void Imprimir(double a, double b)
        {
            Console.WriteLine($"Soma: {a + b}");
        }

        public static void Executar()
        {
            Soma soma = Somar;
            ImprimirSoma imprimir = Imprimir;
            Console.WriteLine(soma(2, 3));
            imprimir(2, 5);

            Func<double, double, double> soma1 = Somar;
            Console.WriteLine(soma1(2.7, 3.8));

            Action<double, double> action = Imprimir;
            action(2.7, 3.8);
        }
    }
}
