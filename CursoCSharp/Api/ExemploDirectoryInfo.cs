using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/Meus Estudos/Dev/CursoCSharp/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists)
            {
               dirInfo.Create();
            }

            Console.WriteLine("============== Arquivos ==================");
            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n ================= Diretórios =================");
            var diretorios = dirInfo.GetDirectories();
            foreach (var diretorio in diretorios)
            {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.Parent.Parent);
            Console.WriteLine(dirInfo.Root);
        }
    }
}
