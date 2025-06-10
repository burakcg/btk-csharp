//For Döngüsü Uygulamaları

// 1-100 arasındaki sayıların toplamını hesaplayınız.
int toplam = 0;
for (int i = 1; i <= 100; i++)
{
    toplam +=  i;
}
System.Console.WriteLine(toplam);

// Klavyeden girilen iki sayı arasındaki tüm sayıların toplamını hesaplayınız.
System.Console.Write("1.sayı:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2.sayı:");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi1 < sayi2)
{
    (sayi1, sayi2) = (sayi2, sayi1);
}

int tp = 0;
for (int i = sayi2 + 1; i < sayi1; i++)
{
    tp += i;
}

System.Console.WriteLine(tp);

// While Döngüsü Uygulama

//1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın ( yukarı aşağı şeklinde yönlendirin)
//Tanımlanan hak bittiğinde oyun bitmeli

var rnd = new Random();
int sayi = rnd.Next(1, 100);
int tahmin = 0;
int cnt = 1;
System.Console.WriteLine("7 tahmin hakkın var.");
while (true)
{
    if (cnt <= 7)
    {
        if (sayi > tahmin)
        {
            System.Console.WriteLine("Yukarı");
        }
        else if (sayi < tahmin)
        {
            System.Console.WriteLine("Aşağı");
        }
        else
        {
            System.Console.WriteLine("Tebrikler!");
            break;
        }
        System.Console.Write(cnt + "." + "tahmin" + " " + "1-100 arsında bir sayı tahmin edin:");
        tahmin = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        System.Console.WriteLine("Tahmin hakkın bitti!");
        break;
    }
    cnt++;
    
}

// foreach 

string ad = "Burak CG";

foreach (var harf in ad)
{
    if (harf == ' ')   // string " "   char ' '
    {
        continue;
    }
    if(char.ToLower(harf) == 'g') { 
        break;
    }
    System.Console.WriteLine(harf);
}