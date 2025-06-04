using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) // Método com ref
        {
            // A variável precisa ser inicializada antes de ser passada como parâmetro
            // Caso contrário, ocorrerá um erro de compilação.
            // int numero = 10; // Isso não é necessário aqui, pois o número já é passado como referência.

            numero += 1000;
        }

        public static void AlterarOut(out int numero) // Método com out
        {
            // A variável precisa ser inicializada dentro do método antes de ser usada
            numero = 0;
            numero += 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b = 4;
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
