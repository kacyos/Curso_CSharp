using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        static int inicial; // valor padrão é 0
        public static void Executar()
        {
            Nullable<int> numero = null;
            int? outroNumero = null;

            if (numero.HasValue)
            {
                Console.WriteLine($"Valor: {numero}");
            }
            else
            {
                Console.WriteLine("Sem valor!");
            }

            int valor = numero ?? 1000;

            Console.WriteLine(valor);

            bool? boolean = null;
            bool isTrue = boolean.GetValueOrDefault(); // Retorna false se for null
            Console.WriteLine(isTrue);

            try
            {
                int x = numero.GetValueOrDefault(); // Lança exceção se for null
                int y = outroNumero.GetValueOrDefault(); // Lança exceção se for null
                Console.WriteLine(x+y);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }
    }
}
