﻿namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Lucas", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 9.0},
                new Aluno() {Nome = "Pedro", Idade = 21, Nota = 7.5},
                new Aluno() {Nome = "Maria", Idade = 23, Nota = 6.0},
                new Aluno() {Nome = "João", Idade = 19, Nota = 8.0},
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 9.0},
            };

            Console.WriteLine("============ Aprovados ===============");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n============== Chamada ==============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => $"{a.Nome}");

            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n===== Aprovados (por idade) =======");
            
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
