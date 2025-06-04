﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X; 
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Cópia do valor
            ponto1.X = 3; // Modifica apenas ponto1

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X: {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Referência ao mesmo objeto
            ponto2.X = 5; // Modifica ponto2 e copiaPonto2 também

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Cópia do Ponto 2 X: {0}", copiaPonto2.X);
        }
    }
}
