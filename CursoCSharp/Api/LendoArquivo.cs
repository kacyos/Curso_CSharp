namespace CursoCSharp.Api
{
    class LendoArquivo
    {
        public static void Executar()
        {
            var path =@"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produro;Preco;Qtd");
                    sw.WriteLine("Caneta;2.50;10");
                    sw.WriteLine("Lapis;1.50;5");
                    sw.WriteLine("Borracha;0.50;20");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
