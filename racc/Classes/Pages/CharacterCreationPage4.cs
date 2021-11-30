using System;
using Classes.Constants;
using Classes.Characters;

namespace Classes.Pages
{
    class CharacterCreationPage4
    {
        public static void initPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Character creation page 4: Ending page\r");
                Console.WriteLine("--------------------------------\n");

                MenuCreator.createMenu(CGeneral.HEADLINE_PAGE_4);
                MenuCreator.endingMenu();

                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Character hero = new Character();
                        hero.printCharacterSheet();
                        break;

                    case 9:
                        return;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        continue;
                }

                Console.Write("\n");
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();
                Environment.Exit(0);

            }
        }
    }
}
