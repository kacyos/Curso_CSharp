namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            if (string.IsNullOrEmpty(Nome) || Idade <= 0)
            {
                return "Os dados não estão preenchidos corretamente.";
            }

            return string.Format($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
