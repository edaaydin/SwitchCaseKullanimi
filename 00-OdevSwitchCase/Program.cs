#region Odev 1 - Günün Adını Bulma. kullanıcıdan gün numarası alınır. (switch case)

Console.Write("Lutfen bir numara giriniz : ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1: Console.WriteLine("Pazartesi"); break;

    case 2: Console.WriteLine("Sali"); break;

    case 3: Console.WriteLine("Carsamba"); break;

    case 4: Console.WriteLine("Persembe"); break;

    case 5: Console.WriteLine("Cuma"); break;

    case 6: Console.WriteLine("Cumartesi"); break;

    case 7: Console.WriteLine("Pazar"); break;

    default:
        Console.WriteLine("Hatali tuslama yaptiniz, Lutfen tekrar deneyiniz !");
        break;
}
#endregion


#region Odev 2 - işlem seçimi. 1 toplama, 2 çıkarma, 3 çarpma, 4 bölme. 2 sayı ve 1 işlem türü için sayı alınır. ve işlem yapılır

Console.WriteLine("İslem 1 : + ");
Console.WriteLine("İslem 2 : - ");
Console.WriteLine("İslem 3 : * ");
Console.WriteLine("İslem 4 : / ");

Console.WriteLine("************");

Console.Write("Seciminiz : ");

string secim = Console.ReadLine();

Console.Write("Lutfen birinci sayinizi giriniz : ");
int birinciSayi = Convert.ToInt32(Console.ReadLine());

Console.Write("Lutfen ikinci sayinizi giriniz : ");
int ikinciSayi = Convert.ToInt32(Console.ReadLine());

int sonuc = 0;

if (secim == "+")
{
    sonuc = birinciSayi + ikinciSayi;
    Console.WriteLine($"Sonucunuz : {sonuc}");
}
else if (secim == "-")
{
    sonuc = birinciSayi - ikinciSayi;
    Console.WriteLine($"Sonucunuz : {sonuc}");
}

else if (secim == "*")
{
    sonuc = birinciSayi * ikinciSayi;
    Console.WriteLine($"Sonucunuz : {sonuc}");
}

else if (secim == "/")
{
    sonuc = birinciSayi / ikinciSayi;
    Console.WriteLine($"Sonucunuz : {sonuc}");
}

else
    Console.WriteLine("Hatali isaret girisi, Lutfen tekrar giriniz !");
#endregion


#region Odev 3 - Bes tane renk belirle ve secilen rengi ekrana yazdir.

Console.WriteLine("1- Siyah");
Console.WriteLine("2- Beyaz");
Console.WriteLine("3- Kirmizi");
Console.WriteLine("4- Sari");
Console.WriteLine("5- Mavi");

Console.Write("Lutfen isleminizi seciniz : ");
int secim = Convert.ToInt32(Console.ReadLine());

switch (secim)
{
    case 1: Console.WriteLine("Seciminiz siyahtir."); break;

    case 2: Console.WriteLine("Seciminiz Beyazdir."); break;

    case 3: Console.WriteLine("Seciminiz Kirmizidir."); break;

    case 4: Console.WriteLine("Seciminiz Saridir."); break;

    case 5: Console.WriteLine("Seciminiz Mavidir."); break;

    default: Console.WriteLine("Hatali secim yaptiniz, Lutfen gecerli bir secim yapiniz !"); break;

}
#endregion


#region Odev 5 - Bir kullanıcının yaşı 18'den büyükse "Yetişkin", değilse "Çocuk" mesajı veren program (ternary if)

Console.Write("Lutfen yasinizi giriniz : ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(yas >= 0 && yas < 18 ? "Cocuk" : yas >= 18 ? "Yetiskin" : "Hatali yas girisi");
#endregion


#region Odev 6 -  Bir ürünün fiyatı belirli bir değerin altında ise "Ucuz", üstünde ise "Pahalı" mesajı veren program (ternary if)

Console.Write("Lutfen urunun fiyatini giriniz : ");
int urunFiyat = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    urunFiyat > 0 && urunFiyat <= 50 ? "Ucuz urun." : urunFiyat > 50 && urunFiyat <= 100 ? "Ortalama Fiyat." :
    urunFiyat > 100 ? "Pahali urun" : "Hatali fiyat girisi, lutfen tekrar deneyiniz !"
    );
#endregion
