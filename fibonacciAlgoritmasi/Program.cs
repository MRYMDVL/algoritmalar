namespace fibonacciAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1.başla
            2.kullanıcıdan kaç terim istediğini al (n)
            3.başlangıç terimleri
           3.1 ilk terime 0 ve ikinci terime 1 ata
            4.ilk iki terimi yazdır
            5.3 ten n e kaadar bir döngü başlat
            5.1 yeni terimi tanımla ve önceki iki terimin toplamına ata ( int c=a+b)
            5.2 yeni terimi yazdır
            5.3 önceki iki terimi kaydır
            6.bitir
             
              
            */
            Console.WriteLine("ilk kac terimi almak istersiniz");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write($"{a } {b} ");
            for (int i=3;i<=n; i++)
            
                {
                int c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;

            
            }
                
        }
    }
}
