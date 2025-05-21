//string
using System.Globalization;

System.Console.WriteLine("\n" + "******string*****");

System.Console.Write("adı:");
var ad = Console.ReadLine();

System.Console.Write("soyad:");
var soyad = Console.ReadLine();

System.Console.Write("yaş:");
var yas = Console.ReadLine();

string mesaj = $"  {ad} {soyad} isimli kişi {yas} yaşındadır.";
System.Console.WriteLine(mesaj);

//String Methods
System.Console.WriteLine("\n"+"***Methods***");

int adet = mesaj.Length;  //Length
System.Console.WriteLine("message length:"+ adet);

int namelength = ad!.Length + soyad!.Length;     // " ! " used for nullable
System.Console.WriteLine("name length:" + namelength);

var nospacemesaj = mesaj.Trim(); //Trim
System.Console.WriteLine(nospacemesaj);

int adet1 = nospacemesaj.Length;
System.Console.WriteLine("message length1:" +adet1);

var sonuc = nospacemesaj.ToUpper(); // ToLower ToUpper
System.Console.WriteLine("upper message:" + sonuc);

var splitmesaj = sonuc.Split(" ")[1]; //Split
System.Console.WriteLine("split message:" + splitmesaj);

var checkmesaj0 = nospacemesaj.StartsWith(" ");
var checkmesaj1 = nospacemesaj.EndsWith(".");
System.Console.WriteLine("message start with space?:" + checkmesaj0 + " " + "message end with dot?:" + checkmesaj1);

var checkmesaj2 = nospacemesaj.Contains("3");
var checkmesaj3 = nospacemesaj.IndexOf("3");
System.Console.WriteLine("Is there a 3 in the message?:" + checkmesaj2 + " " + "index?:" + checkmesaj3);

var msj = nospacemesaj.Substring(0,15);
System.Console.WriteLine(msj);


