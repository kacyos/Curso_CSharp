﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 2.99);
            var p2 = new Produto("Caneta", 2.99);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);
            
            
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
