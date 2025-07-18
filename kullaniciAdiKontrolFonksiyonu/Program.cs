namespace kullaniciAdiKontrolFonksiyonu
{
    internal class Program
    {
        /*
        static string  KullaniciAdiKontrolVeDonustur(string adi)
        {
            if (adi.Length > 3)
            {
                return adi.ToLower();
            }
            else
            {
                return "";
            }
        }
        */

        static void KullaniciAdiKontrol(string adi)
        {
            if (adi.Length >= 3)
            {
                Console.WriteLine($"Kullanıcı adınız : {adi.ToLower()} ");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı 3 karakterden küçük olamaz.");
            }
        }

        static void Main(string[] args)
        {
            //kullanıcıdan kullanıcı adı alıp,kullanıcı adı 3 karakterden fazla olması hepsinin küçük olarak yazdıracaz
            //

            Console.Write("Kullanıcı adınızı girin: ");
            string kullaniciAdi = Console.ReadLine();

            KullaniciAdiKontrol(kullaniciAdi);


        }
    }
}
