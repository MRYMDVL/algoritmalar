namespace dinnerTimeAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          1 - Başla
           2 - 10 elemanlı bir masa dizisi oluştur.
           3 - Olay sayısını kullanıcıdan al.
           4 - Olayları kullanıcıdan alalım.(LRLR0RL1)
           5 - Olayları oku.
           5.1 - Eğer karakter "L" ise soldan(0'dan) başlayarak ilk sıfırı(boş masa) bul ve 1(dolu) yap.
           5.2 - Eğer karakter "R" ise sağdan(9'dan) başlayarak ilk sıfır bul ve 1 yap.
           5.3 - Eğer karakter bir rakam ise dizinin o indisini 0(boş) yapıyoruz.
           6 - Dizinin son halini yazdır.
           7 - Bitir
          */
            int[] table = new int[10];


            Console.WriteLine("Olay sayısını giriniz:");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Olayları giriniz:");
            string events = Console.ReadLine()!;

            foreach (char olay in events)
            {
                if (olay == 'L')
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (table[i] == 0)
                        {
                            table[i] = 1;
                            break;
                        }

                    }
                }
                else if (olay == 'R')
                {
                    for (int i = 9; i >= 0; i--)
                    {
                        if (table[i] == 0)
                        {
                            table[i] = 1;
                            break;
                        }

                    }
                }
                else if (char.IsDigit(olay))
                {
                    int tableIndex = olay - '0';
                    table[tableIndex] = 0;
                }
            }

            foreach (int tableState in table)
            {

                Console.Write(tableState);
            }


        }
    }
}
