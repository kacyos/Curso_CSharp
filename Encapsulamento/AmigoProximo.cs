using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo próximo...");
            Console.WriteLine(amigo.infoPublica); // Acessível, é public
            // Console.WriteLine(amigo.CorDoOlho); // Erro de compilação, não acessível por ser protected
            Console.WriteLine(amigo.NumeroCelular); // Acessível, é internal e estou no mesmo projeto
            Console.WriteLine(amigo.JeitoDeFalar); // Acessível, é protected internal e estou no mesmo projeto
            // Console.WriteLine(amigo.SegredoFamilia); // Erro de compilação, não acessível por ser private protected
            // Console.WriteLine(amigo.EuNaoFalo); // Erro de compilação, não acessível por ser private
        }
    }
}
