using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
    
        public static void Executar()
        {
            var livro = new Produto("Aprendendo C#", 49.90);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Caneca", 19.90),
                new Produto("Caderno", 9.90),
                new Produto("Caderno", 9.90),
            };

            carrinho.UnionWith(combo);
            Console.WriteLine($"Total de itens no carrinho: {carrinho.Count}");

            foreach (var item in carrinho)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

        }
    }
}
