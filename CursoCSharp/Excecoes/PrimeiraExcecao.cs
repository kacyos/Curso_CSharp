using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {

        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque efetuado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim!");
            }
        }
    }
}
