using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (
                   Environment.OSVersion.Platform == PlatformID.Unix ?
                   Environment.GetEnvironmentVariable("HOME") :
                   Environment.ExpandEnvironmentVariables(@"%HOMEDRIVE%%HOMEPATH%\Desktop"));

            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {      

        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Primeira linha do arquivo!");
                    sw.WriteLine("Segunda linha do arquivo!");
                    sw.WriteLine("Terceira linha do arquivo!");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("Quarta linha do arquivo!");
                sw.WriteLine("Quinta linha do arquivo!");
            }
        }
    }
}
