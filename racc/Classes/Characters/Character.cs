using System;
using Classes;
using Classes.Characters;

namespace Classes.Characters
{
    class Character
    {
        CharacterStats charStats;

        public Character()
        {
            charStats = new CharacterStats(PropertyHandler.getRace(), PropertyHandler.getProfession());
        }

        //Print method
        public void printCharacterSheet()
        {
            Console.Clear();
            Console.WriteLine($"{PropertyHandler.getName()} - charactersheet\r");
            Console.WriteLine($"Level {charStats.getLevel()} : {PropertyHandler.getRace()} {PropertyHandler.getProfession()}");

            Console.WriteLine("\n--------------------------------\n");

            Console.WriteLine($"General stats:");
            Console.WriteLine($"\tHealthpoints {charStats.getHealthPoints()}");
            Console.WriteLine($"\tMagicpoints {charStats.getMagicPoints()}");
            Console.WriteLine($"\tArmor {charStats.getArmor()}");

            Console.WriteLine("\n--------------------------------\n");

            Console.WriteLine("Starting Attributes:");
            Console.WriteLine($"\tStrength {charStats.getStrength()}");
            Console.WriteLine($"\tAgility {charStats.getAgility()}");
            Console.WriteLine($"\tConstitution {charStats.getConstitution()}");
            Console.WriteLine($"\tIntelligence {charStats.getIntelligence()}");
            Console.WriteLine($"\tCharisma {charStats.getCharisma()}");
        }
    }
}