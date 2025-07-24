namespace oldGoldenMirrorAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elderglen’in tozlu vadilerinin derinliklerinde, Grizzlebeard adında yaşlı bir altın madencisi yaşardı. Yarım yüzyıldan fazla bir süredir, sadece paslı bir kazma,
             * gıcırdayan bir araba ve altını sezme konusundaki olağanüstü yeteneğiyle toprağı işlerdi. Grizzlebeard zengin değildi ama bilge ve azimliydi. Her gün, gün doğumundan gün batımına kadar madene gider,
             * bir avuç parlayan altın ve işe yaramaz taşlarla geri dönerdi.

                Yaşlı altın madencisi tüm gününü altın ve taş kazmakla geçirirdi. Altını eve götürmek, taşlarıysa geride bırakmak istiyordu.
                Bulduklarını düzenlemek için taşları sıralı n yığına koydu. Ancak, yanlışlıkla altınları da taşlarla birlikte yığınlara yerleştirdi.
                Şimdi, madenci yığınlardan tüm altınları toplamak istiyor, fakat yaşlılığından dolayı her bir altın parçasını hangi yığına koyduğunu hatırlamıyor. 
                Yalnızca altınları bulduğu sırayı hatırlıyor. Madenciye, her bir altın parçasının hangi yığında olduğunu söyleyerek yardım et.

                Girdi Formatı
                İlk satırda, yığın sayısını belirten tek bir tamsayı n bulunur.
                İkinci satırda, her biri i. yığında bulunan parça (altın ve taş) sayısını belirten n tamsayı a₁, a₂, ..., aₙ verilir.
                Üçüncü satırda, madencinin ilgilendiği altın parçalarının sayısını belirten tek bir tamsayı m bulunur.
                Dördüncü satırda, altın parçalarının etiketlerini belirten m tamsayı q₁, q₂, ..., qₘ verilir.

                Kısıtlamalar
                1 ≤ n ≤ 10⁵
                1 ≤ aᵢ ≤ 10³, a₁ + a₂ + ... + aₙ ≤ 10⁶
                1 ≤ m ≤ 10⁵
                1 ≤ qᵢ ≤ a₁ + a₂ + ... + aₙ

                Çıktı Formatı
                Her bir altın etiketi qᵢ için, o altının bulunduğu yığının 1 tabanlı indeksini belirten bir satır yazdırın.*/

            /*
             * n tane yığın
             Sözde Kod :
            1-)Başla
            2-)Kullanıcıdan yığın sayısını al
            3-)Her yığında kaç tane parça olduğunu al
            4-)Toplam altın sayısını al
            5-)Altın numaralarını kullanıcıdan al
            6-)Bitir
            */

            Console.WriteLine("Yigin sayisini girin lütfen:");
            int yiginSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yiginlarda ki parça sayisini girin lütfen:");
            string[] parcalar = Console.ReadLine().Split();
            int[] parcaSayisi = new int[yiginSayisi];
            for (int i = 0; i < yiginSayisi; i++)
            {
                parcaSayisi[i] = Convert.ToInt32(parcalar[i]);
            }
            Console.WriteLine("Toplam altin sayisini girin lütfen:");
            int altinSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altin numaralarini girin lütfen:");
            string[] altinlar = Console.ReadLine().Split();
            int[] altinNum = new int[altinSayisi];
            for (int i = 0; i < altinSayisi; i++)
            {
                altinNum[i] = Convert.ToInt32(altinlar[i]);
            }
            int[] yiginToplami = new int[yiginSayisi];
            yiginToplami[0] = parcaSayisi[0];
            // 3-7-2-9-4-6
            /*
             * Altınların bulunduğu sıra 1 11 28 31
             [(1) 2 3]- [4 5 6 7 8 9 10]-[(11) 12]- [13 14 15 ... 21 ]- [22 23 24 25]- [26 27 (28) 29 30 (31)]
             */
            for (int i = 1; i < yiginSayisi; i++)
            {
                yiginToplami[i] = yiginToplami[i - 1] + parcaSayisi[i];
            }
            foreach (int altin in altinNum)
            {
                for (int i = 0; i < yiginSayisi; i++)
                {
                    if (altin <= yiginToplami[i])
                    {
                        Console.WriteLine("Altınların bulunduğu yığınlar:");
                        Console.Write(i + 1 + " ");
                        break;
                    }
                }

            }

        }

    }
}
