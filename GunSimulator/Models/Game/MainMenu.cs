using GunSimulator.Models.Game.Sections;
namespace GunSimulator.Models.Game
{
    internal class MainMenu
    {
        public void GetMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] Play");
            Console.WriteLine("[2] Choose your Weapon");
            Console.WriteLine("[3] Choose your Skin");
            Console.WriteLine("[4] Quit");
            if (WeaponTypeMenu.WeaponName==default)
            {
                Console.WriteLine("Hələ silah seçilməyib... Zəhmət olmasa silah seç");
            }
            else
            {
                Console.WriteLine($"Seçilən silah: {WeaponTypeMenu.WeaponName}");
            }
            ConsoleKeyInfo enteredKey = Console.ReadKey();
            if (enteredKey.Key == ConsoleKey.D1)
            {
                Console.Clear();
                if (WeaponTypeMenu.WeaponName==default)
                {
                    Console.WriteLine("Hələ silah seçilməyib ana menyuya yönləndirilirsiniz zəhmət olmasa silah seçin...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu menu = new MainMenu();
                    menu.GetMainMenu();
                }
                Console.WriteLine("Oyun başlayır...");
                Console.Clear() ;
                Game game = new Game();
                game.GameInitializer();
                Thread.Sleep(2000);
            }
            else if (enteredKey.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Silah seçim Menyusu yüklənir...");
                Thread.Sleep(2000);
                WeaponTypeMenu weaponTypeMenu = new WeaponTypeMenu();
                weaponTypeMenu.ChooseWeaponType();
                
            }
            else if (enteredKey.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Skin seçim Menyusu yükənir...");
                Thread.Sleep(2000);
                SkinTypeMenu skinTypeMenu = new SkinTypeMenu();
                skinTypeMenu.GetSkinTypeMenu();
            }
            else if (enteredKey.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.WriteLine("Oyundan çıxış edilir...");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
        }
    }
}
