using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;
        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial = new Coordenada();
            coordenadaInicial.X = 10;
            coordenadaInicial.Y = 20;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine($"X: {coordenadaInicial.X}, Y: {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine($"X: {coordenadaFinal.X}, Y: {coordenadaFinal.Y}");
        }
    }
}
