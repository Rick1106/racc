using System;
using Classes.Constants;

public class MenuCreator
{
    public static void createMenu(string headline, string[] items)
    {
        Console.WriteLine(headline);

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("\t{0}. {1}", i + 1, items[i]);
        }
    }

    public static void createMenu(string headline)
    {
        Console.WriteLine(headline);
    }

    public static void controlMenu()
    {
        Console.Write("\n");
        Console.WriteLine($"\t9. {CGeneral.MENUITEM_PAGE_BACK}");
        Console.WriteLine($"\t0. {CGeneral.MENUITEM_PAGE_END}");
    }

    public static void endingMenu()
    {
        Console.Write("\n");
        Console.WriteLine($"\t1. {CGeneral.MENUITEM_PAGE_PRINT}");
        Console.WriteLine($"\t9. {CGeneral.MENUITEM_PAGE_BACK}");
        Console.WriteLine($"\t0. {CGeneral.MENUITEM_PAGE_END}");
    }
}
