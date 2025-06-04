using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá"
                .ToUpper() // OLÁ
                .Insert(3, " World!") // OLÁ World!
                .Replace("OLÁ", "Hello"); // Hello World!

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
