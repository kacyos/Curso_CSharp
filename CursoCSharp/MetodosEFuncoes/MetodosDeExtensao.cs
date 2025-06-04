using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int x, int y)
        {
            return x + y;
        }

        public static int Subtracao(this int x, int y)
        {
            return x - y;
        }
    }
     class MetodosDeExtensao
    {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(2));
            Console.WriteLine(numero.Subtracao(1));
        }
    }
}
