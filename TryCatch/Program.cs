using System;
using System.Linq;
namespace TryCatch
{
    class Program
    {
        static void parola_kontrol(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                throw new Exception("parola 6-10 karakter aralığında olmalıdır.");
            }
            if (!password.Any(char.IsDigit)) // ısdigit sayı mı değil mi kontrolü yapar.
            {
                throw new Exception("parola en az bir rakam içermelidir");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("parola en az bir harf içermelidir.");
            }
        }
        static void Main(string[] args)
        {
            System.Console.Write("parola:");
            string? parola = Console.ReadLine();

            try
            {
                parola_kontrol(parola!);
                System.Console.WriteLine("parola geçerli");
            }
            catch (Exception e)
            {

                System.Console.WriteLine(e.Message);
            }
        }
    }
}