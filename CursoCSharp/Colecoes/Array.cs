using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];

            alunos[0] = "João";
            alunos[1] = "Maria";
            alunos[2] = "Pedro";
            alunos[3] = "Ana";
            alunos[4] = "Lucas";
            // alunos[5] = "Carla"; // Isso causará um erro de índice fora do intervalo

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double soma = 0;
            double[] notas = new double[5] { 7.5, 8.0, 6.5, 9.0, 9.2 };

            foreach(var nota in notas)
            {
                soma += nota;
            }

            double media = (soma / notas.Length);

            Console.WriteLine(media.ToString("f2"));

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);

            Console.WriteLine(palavra);
        }
    }
}
