// if/else Uygulamaları

// Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.

System.Console.WriteLine("Bir işlem türünü yazın:"+"+ - % x");
var islem = Console.ReadLine();
System.Console.Write("sayı giriniz:");
int sayi1 =Convert.ToInt32(Console.ReadLine());
System.Console.Write("sayı giriniz:");
int sayi2 =Convert.ToInt32(Console.ReadLine());

if (islem == "+")
{
    int sonuc = sayi1 + sayi2;
    System.Console.WriteLine(sonuc);
}
if (islem == "-")
{
    int sonuc = sayi1 - sayi2;
    System.Console.WriteLine(sonuc);
}
if (islem == "%")
{
    int sonuc = sayi1 / sayi2;
    System.Console.WriteLine(sonuc);
}
if (islem == "x")
{
    int sonuc = sayi1 * sayi2;
    System.Console.WriteLine(sonuc);
}

else
{
    System.Console.WriteLine("işlem türü seçilmedi.");
}

// Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız.

//0-24 => 0
//25-44 => 1
//45-54 => 2
//55-69 => 3
//70-84 => 4
//85-100 => 5

System.Console.Write("1.yazılı notu:");
int not1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2.yazılı notu:");
int not2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("sözlü notu:");
int not3 = Convert.ToInt32(Console.ReadLine());
int not = 0;
int ort = (not1 + not2 + not3) / 3;
if (ort >= 0 && ort <= 24)
{
    not = 0;
}
else if (ort >= 25 && ort <= 44)
{
    not = 1;
}
else if (ort >= 45 && ort <= 54)
{
    not = 2;
}
else if (ort >= 55 && ort <= 69)
{
    not = 3;
}
else if (ort >= 70 && ort <= 84)
{
    not = 4;
}
else if (ort >= 85 && ort <= 100)
{
    not = 5;
}
else
{
    System.Console.WriteLine("girdiğiniz not hatalı");
}

System.Console.WriteLine("not:" + not + " " + "ortalama:" + ort);

// Girilen 3 sayıdan en büyüğünü bulunuz.
int temp = 0;
if (temp <= not1)
{
    temp = not1;
    if (temp <= not2)
    {
        temp = not2;
    }

    if (temp <= not3)
    {

        temp = not3;
    }
}
else
{
    System.Console.WriteLine("girdiğiniz not hatalı");
}
System.Console.WriteLine("en büyük not:" + temp);

// Switch-Case

int gun = (int)DateTime.Now.DayOfWeek;

switch (gun)
{
    case 0:
        System.Console.WriteLine("pazar");
        break;
    case 1:
        System.Console.WriteLine("pazartesi");
        break;
    case 2:
        System.Console.WriteLine("salı");
        break;
    case 3:
        System.Console.WriteLine("çarşamba");
        break;
    case 4:
        System.Console.WriteLine("perşembe");
        break;
    case 5:
        System.Console.WriteLine("cuma");
        break;
    case 6:
        System.Console.WriteLine("c.tesi");
        break;
    default:
        System.Console.WriteLine("hatalı gün");
        break;
}

// Ternary

System.Console.Write("Bir sayı girin:");
int number = Convert.ToInt32(Console.ReadLine());

var sonuc1 = (number % 2 == 0) ?                     // True              //False                    
                                (number > 0) ? "sayı pozitif ve çift" : "sayı negatif ve çift":     // True
                                (number > 0) ? "sayı pozitif ve tek" : "sayı negatif ve tek";      //False

System.Console.WriteLine(sonuc1);