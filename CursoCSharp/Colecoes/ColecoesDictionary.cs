using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2001, "Harry Potter e a Pedra Filosofal");
            filmes.Add(2002, "Star Wars: Episódio II - Ataque dos Clones");
            filmes.Add(2003, "O Senhor dos Anéis: O Retorno do Rei");

            if (filmes.ContainsKey(2002))
            {
                Console.WriteLine(filmes[2002]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2003));
            }

            Console.WriteLine(filmes.ContainsValue("O Senhor dos Anéis: O Retorno do Rei"));

            Console.WriteLine($"Removeu: {filmes.Remove(2035)}");

            filmes.TryGetValue(2008, out string filme);

            Console.WriteLine(filme);

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> item in filmes)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
            foreach (var item in filmes)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
