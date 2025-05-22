//  String Example

string coursename = ".NET 9 with C# Programming Language";

// Kaç karaktere sahiptir?
int cnumber = coursename.Length;
System.Console.WriteLine("karakter sayısı:" + cnumber);


//Hepsini küçük harf yapınız.
var lowercoursname = coursename.ToLower();
System.Console.WriteLine("lower:" + lowercoursname);

//'.' ile mi başlıyor?
var strcontrol0 = coursename.StartsWith(".");
System.Console.WriteLine("string start with dot?:" + strcontrol0);

// C# bilgisi hangi konumda bulunmaktadır? // C# bilgisi içeriyor mu?
var strcontrol1 = coursename.Contains("C#");
var strcontrol2 = coursename.IndexOf("C#");
System.Console.WriteLine("C# var mı?:" + strcontrol1 + " " + "index?:" + strcontrol2);

// "Language" kelimesi yerine "Lesson" yazınız. **Replace**
var newcoursename = coursename.Replace("Language", "Lesson");
System.Console.WriteLine("course name:" + newcoursename);



