namespace OOPsorucevap
{

    class Program
    {
        static void Main(string[] args)
        {


            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "HTML" }, "HTML");
            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "HTML" }, "C#");
            var soru3 = new Soru(3, "Hangisi en popüler web programlama platformu değildir?", new string[4] { "Python", "Asp.net", "Spring", "Django" }, "Python");

            // var sorular = new Soru[] { soru1, soru2, soru3 }; //array list

            List<Soru> sorular = new List<Soru>();              // generic list
            sorular.Add(soru1);
            sorular.Add(soru2);
            sorular.Add(soru3);
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

            Dictionary<int, string> cevaplar = new Dictionary<int, string>();  //Dictionary
            cevaplar.Add(soru1.cevapIdYazdir(), soru1.cevapYazdir());
            cevaplar.Add(soru2.cevapIdYazdir(), soru2.cevapYazdir());
            cevaplar.Add(soru3.cevapIdYazdir(), soru3.cevapYazdir());

            //update
            cevaplar[soru2.cevapIdYazdir()] = "C Sharp";
            foreach (KeyValuePair<int, string> c in cevaplar)
            {
                System.Console.WriteLine(c.Key + " " + c.Value);
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

        public string cevapYazdir()
        {
            string c = this.Cevap;
            return c;
        }
        public int cevapIdYazdir()
        {
            return this.SoruId;
        }
    }
    
   
}