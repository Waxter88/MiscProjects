using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class to manage console commands

namespace BudgetingApp
{
    internal class ConsoleHelper
    {
        //dynamic console menu, control with arrow keys and enter
        //returns choice as int, of index of menuItems 
        public static int ConsoleMenu(string[] menuItems)
        {
            int menuItem = 0;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == menuItem)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(menuItems[i]);
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (menuItem > 0)
                    {
                        menuItem--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (menuItem < menuItems.Length - 1)
                    {
                        menuItem++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(menuItem);
                    return menuItem;
                }
            }
        }

        
    }
}
