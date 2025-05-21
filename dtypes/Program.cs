// data types
Console.Write("1.sayı:");
var sayi1 = Console.ReadLine();

Console.Write("2.sayı:");
var sayi2 = Console.ReadLine();

var toplam = sayi1 + sayi2;
Console.WriteLine("string" + toplam);

// convert to int
System.Console.WriteLine("\n"+"********string to int*******");
var a = Convert.ToInt32(sayi1); // string to int
var b = Convert.ToInt32(sayi2); // string to int
var toplam1 = a + b;
Console.WriteLine("toplam:" + toplam1);

//implict casting => bilinçsiz1
// explicit casting => bilinçli
System.Console.WriteLine("\n"+"*****casting******");

int x = 11;
long y = x;
string abc = x.ToString();
System.Console.WriteLine("string:"+ "" + sayi1 + " " + abc);

long z = 20;
int q = (int)z;

double h = 10.5;
int i = (int)h;
System.Console.WriteLine("double to int:"+i);

//Nullable
System.Console.WriteLine("\n" + "********Nullable*******");

int? maas = null; // int? maas = default;
int? maas1 = 10;
System.Console.WriteLine("maas:" + maas.HasValue + "\n"+ "maas1:" + maas1.HasValue);
System.Console.WriteLine("maas:" + maas.GetValueOrDefault() + "\n"+ "maas1:" + maas1.GetValueOrDefault());

