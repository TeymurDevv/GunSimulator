using GunSimulator.Models.Game;

namespace GunSimulator.Models
{
    internal class Startup
    {
        public void IntializeSimulator() 
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Silah simulyasiyası başladılır...");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Oyunun ana menyusuna daxil olmaq üçün Enter düyməsini sıxın");
            ConsoleKeyInfo enteredKey = Console.ReadKey();
            if (enteredKey.Key == ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter düyməsinə basdınız 5 saniyə sonra oyuna keçid edəcəksiniz...");
                Thread.Sleep(10);
                Console.Clear();
                MainMenu menu = new MainMenu();
                menu.GetMainMenu();
            }
        }
    }
}
