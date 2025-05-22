// Arrays (Diziler)

var kursadi = ".net 9 ile c# programlama dersleri".Split(" ");
System.Console.WriteLine(kursadi[1]);

// string[] isimler = new string[2];
// isimler[0] = "Ahmet";
// isimler[1] = "Ali";

string[] names = { "Ahmet", "Ali" };
int[] numbers = { 50, 60 };
System.Console.WriteLine($"{numbers[0]} numaralı öğrencinin adı {names[0]}");
System.Console.WriteLine($"{numbers[1]} numaralı öğrencinin adı {names[1]}");

// Array Methods
System.Console.WriteLine("\n" + "*****Array Methods****");

string[] sehirler = { "Zonguldak", "İstanbul", "Sakarya" };
int[] plakalar = {42,67, 34, 06 };

sehirler.SetValue("Ankara", 1);
System.Console.WriteLine(sehirler.GetValue(1));
System.Console.WriteLine(sehirler.Length);
System.Console.WriteLine(Array.IndexOf(sehirler, "Sakarya"));
//Sort
Array.Sort(sehirler); // alfabetik olarak sıralar
Array.Sort(plakalar);

System.Console.WriteLine(sehirler.GetValue(0));
System.Console.WriteLine(sehirler.GetValue(2));
System.Console.WriteLine(plakalar.GetValue(0));
//Reverse
Array.Reverse(plakalar);
System.Console.WriteLine(plakalar.GetValue(0));
//Clone
string[] clonesehir = (string[])sehirler.Clone();
// Array.ForEach(clonesehir, Console.Write); // print array
Console.Write(string.Join(" ", clonesehir));
System.Console.WriteLine();
System.Console.WriteLine(string.Join("\n",clonesehir[1..]));  // print array =  string.join

int[] cloneplaka = plakalar; // Referans
Array.ForEach(cloneplaka, item => Console.Write(item + " "));
System.Console.WriteLine();

//Clear
Array.Clear(plakalar);
Array.Clear(sehirler);
System.Console.WriteLine(plakalar.GetValue(0));
System.Console.WriteLine(plakalar.GetValue(2));

//Array Slicing

string[] iller = { "zonguldak", "bursa", "manisa" };
foreach (var il in iller[1..2])
{
    System.Console.WriteLine(il);
}

string car = "bmw";
System.Console.WriteLine(car[1..3]);

// Array Example
System.Console.WriteLine("\n" + "****Array Example****");

System.Console.Write("name1:");
string? name1 = Console.ReadLine();
System.Console.Write("name2:");
string? name2 = Console.ReadLine();
System.Console.Write("name3:");
string? name3 = Console.ReadLine();

System.Console.Write("not1:");
int not1 =Convert.ToInt32(Console.ReadLine());
System.Console.Write("not2:");
int not2 =Convert.ToInt32(Console.ReadLine());
System.Console.Write("not3:");
int not3 =Convert.ToInt32(Console.ReadLine());

int[] stnot = { not1, not2, not3 };
string?[]? stname = { name1, name2, name3 };
Array.ForEach(stname[..2], Console.WriteLine);
Array.ForEach(stnot[..2], Console.WriteLine);


System.Console.WriteLine("öğrenci sayısı:" + stname.Length);

int toplam = 0;
foreach (var sayi in stnot)
{
    toplam += sayi;
}
Console.WriteLine("not ortalaması:" + toplam / stname.Length);

//Çok boyutlu Diziler
System.Console.WriteLine("\n"+ "***Jagged***");
// Jagged dizi tanımlama: Kişiler ve puanları
        string[] kisiler = { "Ali", "Ayşe", "Mehmet" }; 
        int[][] puanlar = new int[3][]; // Her kişi için puan dizisi

        // Puanları tanımlama (her kişi farklı sayıda puana sahip olabilir)
        puanlar[0] = new int[] { 85, 90, 78 }; // Ali'nin puanları
        puanlar[1] = new int[] { 92, 88 };     // Ayşe'nin puanları
        puanlar[2] = new int[] { 75, 80, 95, 85 }; // Mehmet'in puanları

        // Kişi ve puanlarını yazdırma
        for (int i = 0; i < kisiler.Length; i++)
        {
            Console.Write($"{kisiler[i]}'in puanları: ");
            for (int j = 0; j < puanlar[i].Length; j++)
            {
                Console.Write(puanlar[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Her kişinin puan ortalamasını hesaplama
        for (int i = 0; i < kisiler.Length; i++)
        {
            double top = 0;
            for (int j = 0; j < puanlar[i].Length; j++)
            {
                top += puanlar[i][j];
            }
            double ortalama = top / puanlar[i].Length;
            Console.WriteLine($"{kisiler[i]}'in puan ortalaması: {ortalama:F2}");
        }



