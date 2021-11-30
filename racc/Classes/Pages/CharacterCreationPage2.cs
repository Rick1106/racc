using System;
using Classes.Constants;

namespace Classes.Pages
{
    class CharacterCreationPage2
    {
        public static void initPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Character creation page 2: Profession choice\r");
                Console.WriteLine("--------------------------------\n");

                MenuCreator.createMenu(CGeneral.HEADLINE_PAGE_2, PropertyHandler.getUsableProfessions());
                MenuCreator.controlMenu();

                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        PropertyHandler.setProfession(PropertyHandler.getUsableProfessions()[selection - 1]);
                        break;

                    case 9:
                        return;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                if (PropertyHandler.getProfession().Equals(String.Empty)) continue;
                else CharacterCreationPage3.initPage();

            }
        }
    }
}
