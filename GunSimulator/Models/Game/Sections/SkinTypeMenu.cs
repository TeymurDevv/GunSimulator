namespace GunSimulator.Models.Game.Sections
{
    internal class SkinTypeMenu
    {
        public void GetSkinTypeMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[1] NARA-skin");
            Console.WriteLine("[2] YUGAKURE-skin");
            Console.WriteLine("[3] MAGIC-skin");


            ConsoleKeyInfo enteredKey = Console.ReadKey();

            if (enteredKey.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("KAR-98 Silahı üçün NARA-skin seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }

            if (enteredKey.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("KAR-98 Silahı üçün YUGAKURE-skin seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }

            if (enteredKey.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("KAR-98 Silahı üçün MAGİC-skin seçildi...");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }
        }
    }
}
