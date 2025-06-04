using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Comentarios
    {
        /// <summary>
        /// Método estático somente para demonstrar o uso de comentários
        /// </summary>
        /// <param name="a"></param>
        public static void Executar()
        {
            // Esse é um comentário de uma linha
            Console.WriteLine("Código claro é sempre melhor!");

            /* Esse é um comentário
             * de muitas linhas
             * veja
             */
            Console.WriteLine("O C# tem o XML Comments");
            // Console.WriteLine("Esse código não será executado");

        }
    }
}
