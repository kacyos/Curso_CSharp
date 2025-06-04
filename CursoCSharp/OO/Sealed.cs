using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double Fortuna()
        {
            return 1_000_000_000.00;
        }
    }

    // Não é possível herdar de uma classe selada
    //class FilhoSemSucesso : SemFilho
    //{
    //    // public override double Fortuna() => 1_000_000_000.00;
    //    // Não é possível sobrescrever um método de uma classe selada
    //}

    class Avo
    {
        public virtual bool Legal()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool Legal()
        {
            return true;
        }
    }

    class Filho : Pai
    {
        // Não é possível sobrescrever um método selado
        // public override bool Legal() => false;
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.Fortuna());

            Filho filho = new Filho();
            Console.WriteLine(filho.Legal());
        }
    }
}
