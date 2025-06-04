using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string infoPublica = "Tenho um Instagram!";

        // Herança 
        protected string CorDoOlho = "Azul";

        // Mesmo projeto
        internal ulong NumeroCelular = 5511999999999;

        // Herança e mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Somente essa classe ou herança mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bebida é água";

        // private padrão
        private string EuNaoFalo = "Não sei o que dizer...";

        public void MeusAcessos()
        {
            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(EuNaoFalo);
        }
    }
}
