using System;
using Classes.Constants;
using Classes.Pages;

class Program
{
    static void Main(string[] args)
    {
        bool appIsRunning = true;

        while (appIsRunning)
        {
            Console.Clear();
            Console.WriteLine("Ricks Aborea Character Creator\r");
            Console.WriteLine("--------------------------\n");

            MenuCreator.createMenu(CGeneral.HEADLINE_MAIN_MENU, CGeneral.MAIN_MENU);

            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    CharacterCreationPage1.initPage();
                    break;

                case 2:
                    appIsRunning = false;
                    break;

                default:
                    break;
            }

        }
    }
}