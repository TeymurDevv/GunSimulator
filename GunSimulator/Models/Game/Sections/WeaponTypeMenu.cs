namespace GunSimulator.Models.Game.Sections
{
    internal class WeaponTypeMenu
    {
        public static string WeaponName = default;

        public WeaponTypeMenu(string weaponName)
        {
            WeaponName = weaponName;
        }

        public WeaponTypeMenu() 
        {

        }

        public void ChooseWeaponType()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] KAR-98");
            Console.WriteLine("[2] Desert Eagle");
            Console.WriteLine("[3] AK-47");

            ConsoleKeyInfo enteredKey = Console.ReadKey();

            if (enteredKey.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("KAR-98 Silahı seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                WeaponName = "KAR-98";
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();            
            }

            if (enteredKey.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Desert Eagle Silahı seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                WeaponName = "Desert Eagle";
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }

            if (enteredKey.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("AK-47 Silahı seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                WeaponName = "AK-47";
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }
        }
    }
}
