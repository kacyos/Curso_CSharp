using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
     class ParametrosNoeados
    {
        public static  void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine($"Data formatada: {dia:D2}/{mes:D2}/{ano}"); // Formato de dois dígitos
        }

        public static void Executar()
        {
            Formatar(mes: 1, ano: 2023, dia: 2); // Chamada com parâmetros nomeados
        }
    }
}
