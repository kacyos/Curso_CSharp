using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Tocando...";
        }
    }

    public class CelularSamsung : Celular
    {
        public override string Assistente()
        {
            return "Assistente Bixby";
        }
    }

    public class CelularApple : Celular
    {
        public override string Assistente()
        {
            return "Assistente Siri";
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new CelularSamsung(),
                new CelularApple()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Tocar());
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
