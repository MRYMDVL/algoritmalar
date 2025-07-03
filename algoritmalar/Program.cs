/*
 Verilen bir karakter dizisini (string) tersine çeviren algoritma
        1-Başla
        2-Bir metin giriniz.
        3-Metnin uzunluğunu aldım.
        4-Tersçevrilmismetin diye değişken atadım.
        5-Döngüyü tersten başlat.
        5.1-Ters çevrilmişmetine dizinin karakterlerini tersten ata.
        6-Ters çevrilmiş metini ekrana yazdır.
        7-Bitir
 */

Console.WriteLine("Bir metin giriniz:");
string metin = Console.ReadLine();
int metinUzunlugu = metin.Length;
string tersmetin = "";

for (int i = metinUzunlugu - 1; i >= 0; i--)
{
    tersmetin = tersmetin + metin[i];

}
Console.WriteLine("Ters metin : " + tersmetin);