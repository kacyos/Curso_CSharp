using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double desconto = 0.1;
            string nome;
            public string Nome
            {
                get => "Opcional: " + nome;
                set => nome = value;
            }

            // Propriedades autoimplementadas
            public double Preco { get; set; }

            // Somente leitura
            public double PrecoComDesconto
            {
                get => Preco - (Preco * desconto);
            }

            public CarroOpcional(){}
            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var carro1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(carro1.PrecoComDesconto);

            var carro2 = new CarroOpcional();
            carro2.Nome = "Direção Elétrica";
            carro2.Preco = 2349.9;

            Console.WriteLine(carro1.Nome);
            Console.WriteLine(carro1.Preco);

            Console.WriteLine(carro2.Nome);
            Console.WriteLine(carro2.Preco);
            Console.WriteLine(carro2.PrecoComDesconto);
        }
    }
}
