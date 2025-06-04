using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecoesList
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object? obj)
            {
                return obj is Produto produto &&
                       Nome == produto.Nome &&
                       Preco == produto.Preco;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Nome, Preco);
            }
        }
        public static void Executar()
        {
            var livro = new Produto("Aprendendo C#", 49.90);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Caneca", 19.90),
                new Produto("Caderno", 9.90)
            };

            carrinho.AddRange(combo);
            Console.WriteLine($"Total de itens no carrinho: {carrinho.Count}");
            carrinho.RemoveAt(3); // Remove o terceiro item (índice 2)

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item) + " - ");
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }

            carrinho.Sort((x, y) => x.Preco.CompareTo(y.Preco));

            carrinho.ForEach(item =>
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            });
        }
    }
}
