﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // 5
            Console.WriteLine(!booleano);

            numero1++; // numero1 = numero1 + 1
            Console.WriteLine(numero1); // 3

            --numero1; // numero1 = numero1 - 1
            Console.WriteLine(numero1); // 2

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} -> {numero2}");
        }
    }
}
