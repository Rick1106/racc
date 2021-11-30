using System;
using Classes.Constants;

namespace Classes.Pages
{
    class CharacterCreationPage1
    {
        public static void initPage()
        {
            PropertyHandler.resetValues();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Character creation page 1: Race choice\r");
                Console.WriteLine("--------------------------------\n");

                MenuCreator.createMenu(CGeneral.HEADLINE_PAGE_1, CRace.RACES_ALL);
                MenuCreator.controlMenu();

                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        PropertyHandler.setRace(CRace.RACE_HUMAN);
                        PropertyHandler.setUsableProfessions(CProfession.PROFESSIONS_HUMAN);
                        break;

                    case 2:
                        PropertyHandler.setRace(CRace.RACE_ELF);
                        PropertyHandler.setUsableProfessions(CProfession.PROFESSIONS_ELF);
                        break;

                    case 3:
                        PropertyHandler.setRace(CRace.RACE_DWARF);
                        PropertyHandler.setUsableProfessions(CProfession.PROFESSIONS_DWARF);
                        break;

                    case 4:
                        PropertyHandler.setRace(CRace.RACE_HALFLING);
                        PropertyHandler.setUsableProfessions(CProfession.PROFESSIONS_HAFLING);
                        break;

                    case 5:
                        PropertyHandler.setRace(CRace.RACE_GNOME);
                        PropertyHandler.setUsableProfessions(CProfession.PROFESSIONS_GNOME);
                        break;

                    case 9:
                        return;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                if (PropertyHandler.getRace().Equals(String.Empty)) continue;
                else CharacterCreationPage2.initPage();

            }
        }
    }
}
