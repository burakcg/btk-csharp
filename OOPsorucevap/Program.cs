namespace OOPsorucevap
{

    class Program
    {
        static void Main(string[] args)
        {

            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "HTML" }, "HTML");
            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "HTML" }, "C#");
            var soru3 = new Soru(3, "Hangisi en popüler web programlama platformu değildir?", new string[4] { "Python", "Asp.net", "Spring", "Django" }, "Python");
           
            var sorular = new Soru[] { soru1, soru2, soru3 };
            foreach (var soru in sorular)
            {
                System.Console.WriteLine(soru.soruYazdir());

                //kullanıcıdan cevap al
                System.Console.Write("cevabınız:");
                var cevap = Console.ReadLine();
                if (soru.cevapKontrol(cevap))
                {
                    System.Console.WriteLine("doğru");
                }
                else
                {
                    System.Console.WriteLine("yanlış");
                }
            }
           
        }


    }

    class Soru
    {
        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = soruId;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }
        private int SoruId { get; set; }
        private string SoruMetni { get; set; }
        private string[] Secenekler { get; set; }
        private string Cevap { get; set; }


        public bool cevapKontrol(string cevap)
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }
        public string soruYazdir()
        {
            string soru = "";
            soru += this.SoruMetni + "\n";
            foreach (var secenek in Secenekler)
            {
                soru += secenek + " ";
            }
            return soru;
        }
       
    }
    
   
}