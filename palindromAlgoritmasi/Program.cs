namespace palindromAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            kelimenin palindrom olup olmadığını bulan algoritma
           1-basla
           2-kullanıcıdan kelime al
           3-butun harfleri kucult
           4-tersKelime adında string degisken olustur
           5-tersten dongu baslat
           5.1-her harfi tersKelimeye ata
           6-eğer kelime tersKelimeye eşitse palindromdur değilse palindrom değildir yaz
           7-bitir
            */
            string kelime=Console.ReadLine();
            kelime = kelime.ToLower();
            string tersKelime = "";
            for (int i =kelime.Length-1; i>=0; i--)
            {
                tersKelime += kelime[i];
            }
            if (tersKelime == kelime)
            {
                Console.WriteLine("palindrom kelime");
            }
            else { Console.WriteLine("palindrom değil"); }
        }
    }
}
