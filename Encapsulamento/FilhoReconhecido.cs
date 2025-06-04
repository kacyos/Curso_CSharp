using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public void MeusAcessos()
        {
            Console.WriteLine(infoPublica); // Acessível, é public
            Console.WriteLine(CorDoOlho); // Acessível, é protected e estou na herança
            Console.WriteLine(NumeroCelular); // Acessível, é internal e estou no mesmo projeto
            Console.WriteLine(JeitoDeFalar); // Acessível, é protected internal e estou na herança e mesmo projeto
            Console.WriteLine(SegredoFamilia); // Acessível, é private protected e estou na herança e mesmo projeto
                                               // Console.WriteLine(EuNaoFalo); // Erro de compilação, não acessível por ser private
        }
    }
}
