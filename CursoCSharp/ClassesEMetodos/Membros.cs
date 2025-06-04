namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 20;

            pessoa.ApresentarNoConsole();
            pessoa.Zerar();
            pessoa.ApresentarNoConsole();

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Maria";
            pessoa2.Idade = 25;

            var apresentacao = pessoa2.Apresentar();

            Console.WriteLine(apresentacao.Length);
            Console.WriteLine(apresentacao);
        }
    }
}
