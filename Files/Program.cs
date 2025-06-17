//Dosya yazma ve Ekleme

// Dosya Ekleme
File.WriteAllText("deneme2.txt", "mrb");
File.WriteAllText("deneme.txt", "mrb");

//içeriği günceller
using (StreamWriter sw = File.CreateText("deneme.txt"))
{
    sw.WriteLine("merhaba");
    sw.WriteLine("bcg");
    sw.WriteLine("433");
}

//var olan içeriğe yeni bilgi ekler
using (StreamWriter sw = File.AppendText("deneme.txt"))
{
    sw.WriteLine("Selam");
    sw.WriteLine("btk");
    sw.WriteLine("4231");
}

//Dosya okuma

// StreamReader sr = File.OpenText("deneme.txt");
// var s = "";
// while ((s = sr.ReadLine()) != null)
// {
//     System.Console.WriteLine(s);
// }

string sonuc = File.ReadAllText("deneme.txt");
System.Console.WriteLine(sonuc);
