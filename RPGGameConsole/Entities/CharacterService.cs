using Newtonsoft.Json;
using RPGGameConsole.Entities.Interfaces;
using RPGGameConsole.Entities.Models;

namespace RPGGameConsole.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            var initialCharacter = new Character();


            if (File.Exists($"{basePath}\\conan.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("conan.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }

            return initialCharacter;
        }

    }
}
