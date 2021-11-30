using System;
using Classes.Constants;

namespace Classes.Pages
{
    class CharacterCreationPage3
    {
        public static void initPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Character creation page 3: Name choice\r");
                Console.WriteLine("--------------------------------\n");

                MenuCreator.createMenu(CGeneral.HEADLINE_PAGE_3);
                MenuCreator.controlMenu();

                Console.Write("\nCharacter name or menu item: ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "9":
                        return;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                if (selection.Equals(String.Empty))
                {
                    continue;
                }
                else
                {
                    PropertyHandler.setName(selection);
                    CharacterCreationPage4.initPage();
                }
            }
        }
    }
}
