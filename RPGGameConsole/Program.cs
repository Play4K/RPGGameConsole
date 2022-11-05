using RPGGameConsole.Adventures;
using RPGGameConsole.Entities;
using RPGGameConsole.Game;

namespace RPGGameConsole
{
    internal class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);

        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();
            Console.ReadKey();
        }

        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void MakeMainMenu()
        {
            ConsoleKeyInfo keyInfo;


            var isInputValid = false;

            do
            {
                Console.WriteLine("(S)tart a new game");
                Console.WriteLine("(L)oad a game");
                Console.WriteLine("(C)reate new character");
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.S:
                        isInputValid = true;
                        gameService.StartGame();
                        break;
                    case ConsoleKey.L:
                        isInputValid = true;
                        LoadGame();
                        break;
                    case ConsoleKey.C:
                        isInputValid = true;
                        CreateCharacter();
                        break;
                    default:
                        Console.WriteLine("No valid input! Try again");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (!isInputValid);
        }

        private static void LoadGame()
        {
            Console.WriteLine("You loaded the game");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("You are creating a character");
        }
    }
}
