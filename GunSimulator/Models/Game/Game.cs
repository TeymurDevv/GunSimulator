using GunSimulator.Models.Game.Sections;
namespace GunSimulator.Models.Game
{
    internal class Game
    {
        public int BulletCount = 32;
        WeaponTypeMenu WeaponTypeMenu = new();

        public void Reload()
        {
            if (BulletCount == 32)
            {
                Console.WriteLine("Maksimal sayda gülləniz var Reload-a ehtiyac yoxdur!");
                return;
            }
            BulletCount = 32;
            Console.WriteLine($"Güllə dolduruldu Güllə sayı {BulletCount} oldu.");
        }

        public void oneShot()
        {
            int defaultCount = 32;
            BulletCount--;
            Console.WriteLine($"Atəş edildi. Güllə sayı {BulletCount}/{defaultCount} oldu");
            if (BulletCount==0)
                {
                    Console.WriteLine("Gülləniz bitdi avtomatik Reload olunur");
                    Reload();
                    Thread.Sleep(1000);
                }
        }

        public void TripleShot()
        {
                    int defaultCount = 32;
                    BulletCount = BulletCount - 3;
                    Console.WriteLine($"Atəş edildi. Güllə sayı {BulletCount}/{defaultCount} oldu");

                if (BulletCount <=0)
                {
                    Console.WriteLine("Gülləniz bitdi avtomatik Reload olunur");
                    Reload();
                    Thread.Sleep(1000);
                }
        }

        public void HandleInput()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        oneShot();
                        break;
                    case ConsoleKey.Z:
                        TripleShot();
                        break;
                    case ConsoleKey.R:
                        Reload();
                        break;
                }
            }
        }

            public void GameInitializer()
        {
            HandleInput();
        }
    }
}
