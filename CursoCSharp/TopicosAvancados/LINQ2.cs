namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {

            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Lucas", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 9.0},
                new Aluno() {Nome = "Pedro", Idade = 21, Nota = 7.5},
                new Aluno() {Nome = "Maria", Idade = 23, Nota = 6.0},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 8.0},
                new Aluno() {Nome = "João", Idade = 19, Nota = 8.0},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 10.0},
                 new Aluno() {Nome = "Lucas", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 9.5},

            };

            var pedro = alunos.Single(a => a.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} - {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));

            if (fulano == null)
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            else
            {
                Console.WriteLine($"{fulano.Nome} - {fulano.Nota}");
            }

            var ana = alunos.First(a => a.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nota}");

            var humberto = alunos.FirstOrDefault(a => a.Nome.Equals("Humberto"));

            if (humberto == null)
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            else
            {
                Console.WriteLine($"{humberto.Nome} - {humberto.Nota}");
            }

            var ultimaAna = alunos.LastOrDefault(a => a.Nome.Equals("Ana"));
            Console.WriteLine(ultimaAna.Nota);

            var skip = alunos.Skip(1).Take(3);

            foreach (var aluno in skip)
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Nota}");
            }

            var maiorNota = alunos.Max(a => a.Nota);
            var menorNota = alunos.Min(a => a.Nota);
            var mediaNota = alunos.Average(a => a.Nota);
            var soma = alunos.Sum(a => a.Nota);

            Console.WriteLine($"Maior nota: {maiorNota} - Menor nota:{menorNota} - Soma: {soma} - Media: {mediaNota}");

        }
    }
}
