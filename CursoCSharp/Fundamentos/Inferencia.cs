using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Inferencia
    {
        public static void Executar()
        {
            var nome = "Cacio";
            Console.WriteLine(nome);

            //var idade; (Isto não é permitido na inferência de tipos a variável deve ser inicializada quando usado este tipo)
            //idade = 23;

            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 10;

            int b = 20;

            Console.WriteLine(a + b);
        }
    }
}
