using Encapsulamento;

namespace CursoCSharp.OO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("Filho não reconhecido...");
                Console.WriteLine(infoPublica);
                Console.WriteLine(CorDoOlho);
                // Console.WriteLine(NumeroCelular); // Erro de compilação, não acessível por ser internal
                Console.WriteLine(JeitoDeFalar);
                // Console.WriteLine(SegredoFamilia); // Erro de compilação, não acessível por ser private protected
                // Console.WriteLine(EuNaoFalo); // Erro de compilação, não acessível por ser private
            }
        }

        public class AmigoDistante
        {
            public readonly SubCelebridade amigo = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("Amigo distante...");
                Console.WriteLine(amigo.infoPublica); // Acessível, é public
                //Console.WriteLine(amigo.CorDoOlho); // Erro de compilação, não acessível por ser protected
                //Console.WriteLine(amigo.NumeroCelular); // Erro de compilação, não acessível por ser internal
                //Console.WriteLine(amigo.JeitoDeFalar); // Erro de compilação, não acessível por ser protected internal
                //Console.WriteLine(amigo.SegredoFamilia); // Erro de compilação, não acessível por ser private protected
                //Console.WriteLine(amigo.EuNaoFalo); // Erro de compilação, não acessível por ser private

            }
        }
        public static void Executar()
        {
           SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
