using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;

        public Dependente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero; // Cópia do valor

            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;

            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente("João", 20);
            Dependente copiaDep = dep; // Cópia da referência

            Console.WriteLine($"{dep.Nome} {dep.Idade} | {copiaDep.Nome} {copiaDep.Idade}");

            copiaDep.Nome = "Maria";
            dep.Idade = 30;

            Console.WriteLine($"{dep.Nome} {dep.Idade} | {copiaDep.Nome} {copiaDep.Idade}");
        }
    }
}
