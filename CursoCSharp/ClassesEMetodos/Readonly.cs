using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento()
        {
            return String.Format("{0:dd/MM/yyyy}", Nascimento);
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var cliente1 = new Cliente("Ana Silva", new DateTime(1987, 5, 23));

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(cliente1.GetDataNascimento());
        }
    }
}
