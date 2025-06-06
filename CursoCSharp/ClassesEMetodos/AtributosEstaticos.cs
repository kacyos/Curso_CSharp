﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto() { }
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto(string v1, double v2)
        {
        }

        public double CalcularDesconto()
        {
            return Preco - (Preco * Desconto);
        }
    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 2.5, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Caderno",
                Preco = 15.0,
            };

            Produto.Desconto = 0.9;
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.05;
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
