using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Ana");
            fila.Enqueue("Bia");
            fila.Enqueue("Lia");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue("Alface");
            salada.Enqueue("Agrião");
            salada.Enqueue(true);
            salada.Enqueue(1.5);
            salada.Enqueue(10);

            Console.WriteLine(salada.Contains(10));
        }
    }
}
