using System.Text.RegularExpressions;

namespace sifreAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   while (true)
                {

                    Console.WriteLine("Lütfen bir şifre giriniz:");
                    string sifre=Console.ReadLine();

                    if (sifre.Length<8)
                    {
                        Console.WriteLine("Şifre 8 karakterden uzun olması gerekiyor.");
                        continue;
                    }

                    bool buyukVarmi = false;
                    bool kucukVarmi = false;
                    bool rakamVarmi = false;

                    for (int i = 0; i < sifre.Length; i++)
                    {
                        if (sifre[i] >= 'A' && sifre[i] <= 'Z') 
                        {
                            buyukVarmi=true;
                        }
                        else if (sifre[i] >= 'a' && sifre[i] <= 'z')
                        {
                            kucukVarmi=true;
                        }
                        else if (sifre[i] >= '0' && sifre[i] <= '9') 
                        {
                            rakamVarmi=true;

                        }
                    }
                    if (buyukVarmi && kucukVarmi && rakamVarmi)
                    {
                        Console.WriteLine("Şifre başarıyla oluşturuldu.");
                        Console.Write(sifre);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Şifre en az bir küçük harf bir büyük harf ve rakam içermelidir.");
                    }
                }


    */

            Console.Write("Parola girin: ");
            string parola = Console.ReadLine();

            //  string desen = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$";
            string desen = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$";
            if (Regex.IsMatch(parola, desen))
            {
                Console.WriteLine("Parola güvenli.");
            }
            else
            {
                Console.WriteLine("Parola güvenli değil.");
                Console.WriteLine("Kriter: En az 8 karakter, büyük harf, küçük harf, sayı, özel karakter içermeli.");
            }
        }
    }
}
