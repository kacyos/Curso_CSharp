using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
     class Desafiotributos
    {
        int a = 10;
        public static void Executar()
        {
            // Acessar a variável 'a' dentro do método Executar!
            var desafio = new Desafiotributos();
            Console.WriteLine(desafio.a);
        }
    }
}
