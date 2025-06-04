namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto() { }
        public Moto(string marca, string modelo, uint cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            // 1ª opção
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            // 2ª opção
            //Cilindrada = Math.Abs(cilindrada); // Se o valor for negtivo transforma para positivo

            Cilindrada = cilindrada;
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CBR 1000RR-R");
            moto2.SetCilindrada(1000);
            Console.WriteLine($"\nMarca: {moto2.GetMarca()} - Modelo: {moto2.GetModelo()} - Cilindrada: {moto2.GetCilindrada()}\n");

        }
    }
}
