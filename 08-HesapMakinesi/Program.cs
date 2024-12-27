// Degiskenler - Operatorler - TipDonusumleri - KararYapiları

// Hesap Makinesi Ornegi
// iki sayi al ve 1 islem yaptır

Console.WriteLine("Hesap Makinesi");
Console.WriteLine("\n*****\n");

Console.WriteLine("lutfen Birinci Sayinizi Giriniz");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("lutfen Birinci Sayinizi Giriniz");
int sayi2 = int.Parse(Console.ReadLine());


Console.WriteLine("Lutfen yapmak istedigini islemi seciniz !");

Console.WriteLine("1- Toplama");
Console.WriteLine("2- Cıkarma");
Console.WriteLine("3- Carpma");
Console.WriteLine("4- Bolme");

int giris = int.Parse(Console.ReadLine());

int hesap = 0;


switch (giris)
{
    case 1:
        hesap = sayi1 + sayi2;
        Console.WriteLine(hesap);
        break;

    case 2:
        hesap = sayi1 - sayi2;
        Console.WriteLine(hesap);
        break;
    case 3:
        hesap = sayi1 * sayi2;
        Console.WriteLine(hesap);
        break;
    case 4:
        hesap = sayi1 / sayi2;
        Console.WriteLine(hesap);
        break;

    default:
        Console.WriteLine("Hatali Tuslama yaptiniz");
        break;
}