using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            // Aqui, o construtor da classe base (Animal) é chamado com o parâmetro 'nome'.
            // Isso garante que a propriedade Nome seja inicializada corretamente.
            Console.WriteLine($"Cachorro {nome} inicializado!");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Altura: {Altura}";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike", 0.5);
            var toto = new Cachorro("Toto");

            Console.WriteLine(spike);
            Console.WriteLine(toto);
        }
    }
}
