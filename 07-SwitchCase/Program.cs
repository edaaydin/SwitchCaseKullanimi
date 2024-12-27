/*
 
Switch Case 
if else mantıgıyla neredeyse tamamen aynıdır. Aradaki fark if-else büyüklük küçüklük gibi durumları kontrol ederken 
switch case sadece eşitlik durumlarını kontrol eder.

- Kendisine ait bir indexleme mekanizmasi kullanır.

Sözdizimi:

switch(kosul)
    
    case "a" : statement ; break;


 */


#region Ornek1

// Dışarıdan mevsim gir ve hangi ay olduğunu söyle.

Console.WriteLine("Bir mevsim giriniz.");
string mevsim = Console.ReadLine();

switch (mevsim)
{
    case "kis": Console.WriteLine("Aralik-Ocak-Subat"); break;
    case "ilkbahar": Console.WriteLine("Mart-Nisan-Mayıs"); break;
    case "yaz": Console.WriteLine("Haziran-Temmuz-Ağustos"); break;
    case "sonbahar": Console.WriteLine("Eylül-Ekim-Kasim"); break;
    default:
        Console.WriteLine("Boyle bir mevsim yok");
        break;
}
#endregion

// Soru 2

Console.WriteLine("Lutfen bir numara giriniz");

int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1: Console.WriteLine("C#"); break;
    case 2: Console.WriteLine("VB"); break;
    case 3: Console.WriteLine("Java"); break;
    case 4: Console.WriteLine("C"); break;
    default:
        Console.WriteLine("Hatali numara girisi"); break;
        break;

}

//Soru 3 

Console.WriteLine("Lutfen giris kimliginizi yaziniz :");
string kimlik = Console.ReadLine();

switch (kimlik)
{
    case "Yonetici": Console.WriteLine("Yonetim paneline hosgeldiniz"); break;
    case "CEO": Console.WriteLine("Yonetim paneline hosgeldiniz"); break;
    case "Baskan": Console.WriteLine("Yonetim paneline hosgeldiniz"); break;
    case "Admin": Console.WriteLine("Yonetim paneline hosgeldiniz"); break;
    case "Uye": Console.WriteLine("Anasayfaya hosgeldiniz"); break;
    default:
        Console.WriteLine("Siteye giris yetkiniz yoktur."); break;
        break;
}

// Soru 4 

Console.WriteLine("Lutfen harf giriniz");
string harf = Console.ReadLine();

switch (harf)
{
    case "A": Console.WriteLine("Gectiniz"); break;
    case "B": Console.WriteLine("Gectiniz"); break;
    case "C": Console.WriteLine("Gectiniz"); break;
    case "D": Console.WriteLine("Ortalama ile gectiniz"); break;
    case "E": Console.WriteLine("Kaldınız"); break;
    case "F": Console.WriteLine("Kaldınız"); break;

}