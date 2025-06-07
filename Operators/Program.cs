//Aritmetik Operatçr Uygulamaları

// a = 10, b = 5, c = 20 ise c-a farkının b katı kaçtır?

int a = 10;
int b = 5;
int c = 20;

int sonuc = (c - a) * b;

System.Console.WriteLine("1)" + sonuc);

// int? a1 = 50 ; int b1 = 20; ise a + b değerini hesaplayınız. (eğer a null ise sonuç nedir?)

//int? a1 = 50;
int? a1 = null;
int b1 = 20;

var sonuc1 = a1 + b1;
if (sonuc1 == null)
{
    sonuc1 = (a1 ?? 1) + b1;
    System.Console.WriteLine("2)" + sonuc1);
}
else
{
    System.Console.WriteLine("2)" + sonuc1);
}

// a2 = 10 b2 = 20 ise a = b--; atamasından sonra a ve b değerleri ne olur?

int a2 = 10;
int b2 = 20;

a2 = b2--;
System.Console.WriteLine(a2);
System.Console.WriteLine(b2);

//Klavyeden girilen sayının tek/çift kontrolünü yapınız.

System.Console.Write("Bir sayi giriniz:");
int? number = Convert.ToInt32(Console.ReadLine());
//int? number = int.Parse(Console.ReadLine() ?? "0");
int b3 = 2;
if (number == null)
{
    System.Console.WriteLine("Lütfen bir sayi giriniz!");
}
else
{
    int sonuc3 = (int)number % b3;
    if (sonuc3 == 0)
    {
        System.Console.WriteLine("sayi cift");
    }
    else
    {
        System.Console.WriteLine("sayi tek");
    }
    
}

//Math
double sonuc01;
sonuc01 = Math.Pow(2, 3); // üs
sonuc01 = Math.Sqrt(25); // kök
sonuc01 = Math.Abs(-10); // mutlak değer
sonuc01 = Math.Round(5.4); // 5.4 aşağı 5.5 yukarı yuvarlar
sonuc01 = Math.Ceiling(5.4); // 5.4 yukarı yuvarlar
sonuc01 = Math.Floor(5.6); // 5.6 aşağı yuvarlar yuvarlar
sonuc01 = Math.Max(10, 20); // büyük olanı seçer
sonuc01 = Math.Min(10, 20); // küçük olanı seçer

System.Console.WriteLine(sonuc01);

//Karşılaştırma Operatör Uygulamaları

//Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiz.

System.Console.Write("Yaşınızı giriniz:");
int yas = int.Parse(Console.ReadLine() ?? "0");

if (yas >= 18)
{
    System.Console.WriteLine("oy kullanabilir.");
}

else
{
    System.Console.WriteLine("oy kullanamaz.");
}

//girilen sayının işaretini kontrol ediniz.

if (yas < 0)
{
    System.Console.WriteLine("negatif");
}
else
{
    System.Console.WriteLine("pozitif");
}

//Girilen sayının tek/çift durumunu kontrol ediniz.

if (yas % 2 == 0)
{
    System.Console.WriteLine("cift");
}
else
{
    System.Console.WriteLine("tek");
}

//Mantıksal Operatör Uygulamaları

// Yaşı 18'den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.

System.Console.Write("Yaşınızı giriniz:");
int yas1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Veli izni varsa E yoksa H yazın:");
string? perm = Console.ReadLine();
var result = perm?.ToUpper() ?? string.Empty;

if (yas1 >= 18 || result == "E")
{
    System.Console.WriteLine("çalışabilir.");
}
else
{
    System.Console.WriteLine("çalışamaz.");
}

//Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırın.

System.Console.Write("not giriniz:");
int not = Convert.ToInt32(Console.ReadLine() ?? "0");

if (not >= 50 && not <= 100)
{
    System.Console.WriteLine("geçti.");
}
else
{
    System.Console.WriteLine("kaldı.");
}

// Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

System.Console.Write("not giriniz:");
int not1 = Convert.ToInt32(Console.ReadLine() ?? "0");
//ort = (not1 + not)/2;
int[] nots = { not1, not };

int toplam = 0;
foreach (var sayi in nots)
{
    toplam += sayi;
}
int ort = toplam / nots.Length;

if (ort >= 70 && not >= 50 && not1 >= 50)
{
    System.Console.WriteLine("teşekkür belgesi alabilir." + "ort:" + ort);
}
else
{
    System.Console.WriteLine("teşekkür belgesi alamaz." + "ort:" + ort);
}

//işe girmek için en az ön lisans ya da lisans mezunu olma durumunu sigara kullanmama koşulu ile kontrol ediniz.

string egitim = "lisans";
bool smoking = true;

var sonuck = ((egitim == "lisans" || egitim == "önlisans") && (!smoking)) ? "işe girebilir" : "işe giremez";
System.Console.WriteLine(sonuck);
