﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
     class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();

            Double.TryParse(entrada, out double nota);

            Console.Write("\nPossui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada.ToUpper() == "S")
            //    bomComportamento = true;

            bomComportamento = entrada.ToUpper() == "S";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
