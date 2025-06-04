using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
   class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }    

        public static int Multiplicar(int a, int b)
        {           
            return a * b;
        }
    } 

     class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = Calculadora.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            var calculadora = new Calculadora();
            var resultado2 = calculadora.Somar(2, 2);
            Console.WriteLine($"Resultado: {resultado2}");
        }
    }
}
