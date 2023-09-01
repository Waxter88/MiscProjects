using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1124_Lab_3___Jackson_Pipe
{
    class Program
    {
        // PROG1124 LAB 3 - Iteration
        // By: Jackson Pipe
        // Date: 10/08/2021

        //TODO
        //add yes/no to continue before starting next iteration of program

        public static int width;
        public static string message;
        public static bool  go = true;

        static void Main(string[] args)
        {
            do
            {
                init();
                createBanner(width, message);
                Console.WriteLine("\n\nCreate a new banner? (Y/N)");//change this to add yes to continnue, no to exit
                string newBanner = Console.ReadLine();
                if(newBanner == "Y")
                {
                    go = true;
                }else if(newBanner == "N")
                {
                    go = false;
                }
                else
                {
                    Console.WriteLine("You did not input Y/N. Program will continue.");
                }
                Console.Clear();
            } while (go);
            
        }

        public static void init()
        {
            string tempwidth;
            bool isnum;
            Console.WriteLine("PROG 1124 - Lab 3");
            Console.WriteLine("By: Jackson Pipe\n\n");

            Console.WriteLine("Enter your message: \n");
            message = Console.ReadLine();

            if(message.Length == 0)
            {
                Console.WriteLine("No value entered for message. Banner will be blank.\n");
            }

            Console.WriteLine("Enter width of banner: \n");
            tempwidth = Console.ReadLine();
            isnum = int.TryParse(tempwidth, out width);

            if(isnum == false)
            {
                Console.WriteLine("Enter a number for the width. Cannot have any letters or decimals. Width set to 0.");
            }
            Console.WriteLine("\n\n");
        }

        public static void createBanner(int width, string message)
        {
            String banner = "*";
            String space = " ";
            String temp = "";
            int centre;
            int height = 4; // fixed height (for now?)

            if(message.Length > width)
            {
                width += message.Length;
                Console.WriteLine("Width entered was too little for your message, width was increased by: " + message.Length + "\n");
            }
            if(width % 2 != 0 && message.Length % 2 == 0)
            {
                Console.WriteLine("Width is uneven, message length is even. Width decreased by one to center text.\n");
                width -= 1;
            }
            if(width % 2 == 0 && message.Length % 2 != 0)
            {
                Console.WriteLine("Width is even, message length is uneven. Width increased by one to center text.\n");
                width += 1;
            }

            centre = (width - message.Length) / 2; // calculate amount of spaces on either side of message

            for (int i = 0; i < width-1; i++)//top of banner
            {
                banner += "*";
                space += " ";
            }

            banner += "**" + "\n";
            
            for(int k = 0; k < centre; k++)//add up spaces in temp, dependent on centre (amount of spaces on either side of message)
            {
                temp += " ";
            }

            for(int j = 0; j < height; j++)//sides of banner
            {
                if(j != height/2)//if half height, insert the message
                banner += "*" + space + "*" + "\n";
                else
                {
                    banner += "*" + temp + message + temp + "*" + "\n";
                }
            }

            banner += "*" + space + "*" + "\n";

            for (int i = 0; i <= width; i++)//bottom of banner
            {
                banner += "*";
            }
            banner += "*";
            Console.Write(banner);
        }
    }
}
