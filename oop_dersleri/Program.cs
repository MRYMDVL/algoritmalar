namespace oop_dersleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP- Nesne Yönelimli Programlama
            /*
            //Değer tipli değişkenler -Referans tipli değişkenler
             * 
                OOP-Nesne Yönelimli Programlama:Gerçek dünyadaki nesneleri ve davranışlarını yazılımda modellememizi sağlayan bir programlama yaklaşımıdır.
                Amacı: Kodun daha düzenli,yeniden kullanılabilir, bakımı kolay, kolay analaşılır ve genişletilebilir olmasını sağlamaktır.

               Temel Kavramlar: Sınıf(class):Nesnenin nasıl olacağını tarif eden şablondur. Gerçekleşmiş bir şey ortada yoktur.
                Sınıfların içiersinde nesnenin özellikleri ve davranışları tanımlanır.
               Nesne(object): Sınıfın bir örneğidir. Sınıfın somutlaşmış halidir. gerçek bir şeydir.Neseneler sınflardan üretilir.
                
                class SınıfAdı
                {
                    // Özellikler
                    // Davranışlar
                }
                class Ogrenci
                {
                    string Ad
                    string Soyad 
                    int Yas
                    void DersCalis() 
                    {
                        Console.WriteLine("Ders çalışılıyor...");
                    }
                }

            OOP Temel İlkeleri:
            Kapsülleme(Encapsulation): Nesnenin içinde bulunan önemli verleri saklayıp korumak ve verilere dışardan erişimi kontrollü hale getirmek demektir. 
            Kalıtım(Inheritance): Bir sınıfın özelliklerini ve davranışlarını başka bir sınıfa aktarmak demektir. Bu sayede kod tekrarını önleriz.
            Çok Biçimlilik(Polymorphism): Bir nesnenin farklı şekillerde davranabilmesi demektir. Örneğin, bir metotun farklı sınıflarda farklı şekillerde uygulanmasıdır.
            Soyutlama(Abstraction): Karmaşık sistemlerin basitleştirilmesi ve sadece gerekli bilgilerin gösterilmesi demektir. Gereksiz detaylardan kaçınarak, önemli olan bilgileri ön plana çıkarmaktır.

             */
            #endregion

            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.ad = "Ahmet";
            //ogrenci.soyad = "Yılmaz";
            //ogrenci.yas = 20;
            //ogrenci.DersCalis();

            //Ogrenci ogrenci2 = new Ogrenci();
            //ogrenci2.ad = "Ayşe";
            //ogrenci2.soyad = "Demir";
            //ogrenci2.yas = 22;
            //ogrenci2.DersCalis();

            //Ogrenci ogrenci3 = new Ogrenci();
            //ogrenci3.ad = "Mehmet";
            //ogrenci3.soyad = "Kara";
            //ogrenci3.yas = 19;
            //ogrenci3.DersCalis();

            //BankaHesabi hesap = new BankaHesabi();
            ////hesap.bakiye = 1000; // Bu satır hata verecektir çünkü bakiye private olarak tanımlanmıştır.
            //hesap.ParaYatir(0); // Para yatırma işlemi
            //hesap.ParaYatir(1000); // 1000 TL yatırma işlemi
            //hesap.ParaYatir(500); // 500 TL yatırma işlemi
            //hesap.ParaCek(200); // 200 TL çekme işlemi
            //hesap.ParaCek(1500); // 1500 TL çekme işlemi (yetersiz bakiye durumu)

            //Personel personel = new Personel();
            //personel.Ad = "Ali";
            //personel.Soyad = "Veli";
            //personel.Yas = 30;
            //personel.Adres = "İstanbul";
            //personel.Telefon = "1234567890";
            //personel.BilgiYazdir();

            //Ogretmen ogretmen = new Ogretmen();
            //ogretmen.Ad = "Ayşe";
            //ogretmen.Soyad = "Kara";
            //ogretmen.Yas = 35;
            //ogretmen.Adres = "Ankara";
            //ogretmen.Telefon = "0987654321";
            //ogretmen.Brans = "Matematik";
            //ogretmen.BilgiYazdir();
            //ogretmen.DersAnlat(); // Ogretmen sınıfının DersAnlat metodunu çağırıyoruz

            //Guvenlik guvenlik = new Guvenlik();
            //guvenlik.Ad = "Mehmet";
            //guvenlik.Soyad = "Demir";
            //guvenlik.Yas = 40;
            //guvenlik.Adres = "İzmir";
            //guvenlik.Telefon = "1122334455";
            //guvenlik.BilgiYazdir();
            //guvenlik.Gorev = "Güvenlik Görevlisi";
            //guvenlik.DevriyeYap(); // Guvenlik sınıfının DevriyeYap metodunu çağırıyoruz


            //Hayvan kedi = new Kedi(); // Hayvan sınıfından bir referans oluşturuyoruz
            //kedi.SesCikar(); // Kedi sınıfının SesCikar metodunu çağırıyoruz
            //Hayvan kopek = new Kopek(); // Hayvan sınıfından bir referans oluşturuyoruz
            //kopek.SesCikar(); // Kopek sınıfının SesCikar metodunu çağırıyoruz

            Daire daire = new Daire(); // Daire sınıfından bir nesne oluşturuyoruz
            daire.YariCap = 5; // Dairenin yarıçapını ayarlıyoruz
            double alan=daire.Alan(); // Dairenin alanını hesaplıyoruz
            Console.WriteLine($"Dairenin Alanı: {alan}"); // Dairenin alanını ekrana yazdırıyoruz
            Console.WriteLine($"Dairenin Çevresi: {daire.Cevre()}"); // Dairenin çevresini ekrana yazdırıyoruz
            Kare kare = new Kare(); // Kare sınıfından bir nesne oluşturuyoruz
            kare.KenarUzunlugu = 4; // Karenin kenar uzunluğunu ayarlıyoruz
            Console.WriteLine($"Karenin Alanı: {kare.Alan()}"); // Karenin alanını hesaplıyoruz ve ekrana yazdırıyoruz
            Console.WriteLine($"Karenin Çevresi: {kare.Cevre()}"); // Karenin çevresini hesaplıyoruz ve ekrana yazdırıyoruz
        }
    }
    #region Kapsülleme(Encapsulation)
    // Kapsülleme(Encapsulation): Nesnenin içinde bulunan önemli verleri saklayıp korumak ve verilere dışardan erişimi kontrollü hale getirmek demektir.
    //class BankaHesabi
    //{
    //    private double bakiye; // private erişim belirleyici ile dışarıdan erişimi engelledik
    //    public void ParaYatir(double miktar)
    //    {
    //        if (miktar > 0)
    //        {
    //            bakiye += miktar;
    //            Console.WriteLine($"Para yatırıldı: {miktar} TL. Yeni bakiye: {bakiye} TL.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Geçersiz miktar.");
    //        }
    //    }
    //    public void ParaCek(double miktar)
    //    {
    //        if (miktar > 0 && miktar <= bakiye)
    //        {
    //            bakiye -= miktar;
    //            Console.WriteLine($"Para çekildi: {miktar} TL. Yeni bakiye: {bakiye} TL.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Geçersiz veya yetersiz bakiye.");
    //        }
    //    }

    //}
    #endregion

    #region Kalıtım(Inheritance)
    ////Kalıtım(Inheritance): Bir sınıfın özelliklerini ve davranışlarını başka bir sınıfa aktarmak demektir. Bu sayede kod tekrarını önleriz.
    //class Personel
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public int Yas { get; set; }
    //    public string Adres { get; set; }
    //    public string Telefon { get; set; }

    //    public void BilgiYazdir()
    //    {
    //        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Yaş: {Yas}");
    //    }

    //}
    //class Ogretmen : Personel
    //{
    //    public string Brans { get; set; }
    //    public void DersAnlat()
    //    {
    //        base.BilgiYazdir(); // Personel sınıfının BilgiYazdir metodunu çağırıyoruz
    //        Console.WriteLine($"Çokgenler Anlatılıyor");

    //    }
    //}
    //class Guvenlik : Personel
    //{
    //    public string Gorev { get; set; }
    //    public void DevriyeYap()
    //    {
    //        Console.WriteLine($"{Ad} devriye yapıyor.");
    //    }
    //}
    #endregion

    #region Çok Biçimlilik(Polymorphism)
    // Çok Biçimlilik(Polymorphism): Bir nesnenin farklı şekillerde davranabilmesi demektir. Örneğin, bir metotun farklı sınıflarda farklı şekillerde uygulanmasıdır.
    //class Hayvan
    //{
    //    public virtual void SesCikar() //virtual anahtar kelimesi ile metodu sanal hale getiriyoruz ve değiştirilebilir hale getiriyoruz
    //    {
    //        Console.WriteLine("Hayvan ses çıkarıyor.");
    //    }
    //}
    //class Kedi : Hayvan
    //{
    //    public override void SesCikar() //override anahtar kelimesi ile metodu geçersiz kılıyoruz ve kendi implementasyonumuzu sağlıyoruz
    //    {
    //        Console.WriteLine("Miyav!");
    //    }
    //}
    //class Kopek : Hayvan
    //{
    //    public override void SesCikar()
    //    {
    //        Console.WriteLine("Hav!");
    //    }
    //}
    #endregion

    #region Soyutlama(Abstraction)
    //Soyutlama(Abstraction): Karmaşık sistemlerin basitleştirilmesi ve sadece gerekli bilgilerin gösterilmesi demektir. Gereksiz detaylardan kaçınarak, önemli olan bilgileri ön plana çıkarmaktır.
    abstract class Sekil // abstract anahtar kelimesi ile sınıfı soyut hale getiriyoruz
    {
        public abstract double Alan(); // abstract metot, alt sınıflarda implement edilmesi zorunludur
        public abstract double Cevre(); // abstract metot, alt sınıflarda implement edilmesi zorunludur
    }

    class Daire : Sekil // Daire sınıfı Sekil sınıfından kalıtım alıyor
    {
        public double YariCap { get; set; }
        public override double Alan() // Daire'nin alanını hesaplayan metot
        {
            return Math.PI * YariCap * YariCap;
        }
        public override double Cevre() // Daire'nin çevresini hesaplayan metot
        {
            return 2 * Math.PI * YariCap;
        }
    }
    class Kare : Sekil // Kare sınıfı Sekil sınıfından kalıtım alıyor
    {
        public double KenarUzunlugu { get; set; }
        public override double Alan() // Karenin alanını hesaplayan metot
        {
            return KenarUzunlugu * KenarUzunlugu;
        }
        public override double Cevre() // Karenin çevresini hesaplayan metot
        {
            return 4 * KenarUzunlugu;
        }
    }
    #endregion
}