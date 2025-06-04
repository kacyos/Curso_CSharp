using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Heranca
    {
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            private int VelocidadeAtual;

            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AleterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public virtual int Acelerar()
            {
                return AleterarVelocidade(5);
            }

            public int Frear()
            {
                return AleterarVelocidade(-5);
            }
        }

        public class Uno : Carro
        {
            public Uno() : base(200) { }
        }

        public class Ferrari : Carro
        {

            public Ferrari() : base(400) { }

            public override int Acelerar()
            {
                return AleterarVelocidade(15);
            }

            public new int Frear()
            {
                return AleterarVelocidade(-15);
            }
        }

        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno uno = new Uno();
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());

            Console.WriteLine("Ferrari com o tipo Carro...");
            Carro carro = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Frear()); // Chama o método Frear da classe Carro, não o da Ferrari
            Console.WriteLine(carro.Frear()); 
            Console.WriteLine(carro.Frear());

            Console.WriteLine("Uno com o tipo Carro...");
            carro = new Uno();
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
        }
    }
}
