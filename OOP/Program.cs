namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Player ply1 = new Player();
            ply1.PlayerNo = "45";
            ply1.Ad = "Victor";
            ply1.Soyad = "Osimhen";
            ply1.Takim = "GS";

            Player ply2 = new Player();
            ply2.PlayerNo = "9";
            ply2.Ad = "Mauro";
            ply2.Soyad = "İcardi";
            ply2.Takim = "GS";

            Player ply3 = new Player();
            ply3.PlayerNo = "34";
            ply3.Ad = "Lucas";
            ply3.Soyad = "Torreira";
            ply3.Takim = "GS";

            Player[] players = new Player[3];
            players[0] = ply1;
            players[1] = ply2;
            players[2] = ply3;

            foreach (var Player in players)
            {
                System.Console.WriteLine($"{Player.PlayerNo} numaralı oyuncunun adı {Player.Ad} {Player.Soyad} ve takımı {Player.Takim}'dır.");   
            }
        }
    }

    class Player
    {
        //propert => string, int
        public string? PlayerNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Takim { get; set; }

    }


}
