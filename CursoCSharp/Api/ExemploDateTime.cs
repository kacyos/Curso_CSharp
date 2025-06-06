﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2025, day: 03, month: 08);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Criar data sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com hora
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour);
            Console.WriteLine("Minutos: " + agora.Minute);

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(agora.ToString("dd"));
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("D"));
            Console.WriteLine(agora.ToString("g"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
