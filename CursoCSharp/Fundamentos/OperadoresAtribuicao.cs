using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var numero = 3;
            numero = 7; // Atribuição simples
            numero += 10; // numero = numero + 10
            numero -= 3; // numero = numero - 3
            numero *= 5; // numero = numero * 5
            numero /= 2; // numero = numero / 2

            Console.WriteLine(numero);

            int a = 1;
            int b = a;

            a++; // a = a + 1
            b--; // b = b - 1

            Console.WriteLine($"{a} - {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Lucas";

            dynamic d = c;
            d.nome = "João";

            Console.WriteLine(c.nome);
        }
    }
}
