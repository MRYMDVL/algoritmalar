namespace epostaFormatiKontrolAlgoritmasi
{
    internal class Program
    {
        static bool EpostaKontrol(string eposta)
        {
            return eposta.Contains("@") && eposta.EndsWith(".com");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("E-posta adresini gir:");
            string eposta = Console.ReadLine();
            if (EpostaKontrol(eposta))
            {
                Console.WriteLine($"Gecerli eposta.epostaniz : {eposta}");

            }
            else
            {
                Console.WriteLine("Gcersiz eposta.");

            }

        }
    }
}
