using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Comedia;
            Console.WriteLine(id);

            var filme1 = new Filme();
            filme1.Titulo = "Zumbilândia";
            filme1.GeneroDoFilme = Genero.Terror;

            Console.WriteLine("{0} é {1}", filme1.Titulo, filme1.GeneroDoFilme);
        }
    }
}
