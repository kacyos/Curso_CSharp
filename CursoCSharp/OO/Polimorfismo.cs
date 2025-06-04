using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;
        public Comida() { }
        public Comida(double peso)
        {
            Peso = peso;
        }
    }
    internal class Polimorfismo
    {
        public class Feijao : Comida {}

        public class Arroz : Comida {}

        public class Carne : Comida {}

        public class Pessoa
        {
            public double Peso;

            //public void Comer(Feijao feijao)
            //{
            //    Peso += feijao.Peso;
            //}

            //public void Comer(Arroz arroz)
            //{
            //    Peso += arroz.Peso;
            //}


            //public void Comer(Carne carne)
            //{
            //    Peso += carne.Peso;
            //}

            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar()
        {

            Feijao feijao = new Feijao();
            feijao.Peso = 0.3;

            Arroz arroz = new Arroz();
            arroz.Peso = 0.25;

            Carne carne = new Carne();
            carne.Peso = 0.3;

            Pessoa pessoa = new Pessoa();
            pessoa.Peso = 70.0;
            pessoa.Comer(feijao);
            pessoa.Comer(arroz);
            pessoa.Comer(carne);

            Console.WriteLine($"O peso da pessoa é {pessoa.Peso}Kg");
        }
    }
}
