using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    internal class Manager_Menu
    {


        public static void UserMenu()
        {
            bool flag = true;

            do
            {
                Console.WriteLine("Нажмите на клавишу для выбора действия");

                var input = Console.ReadKey();

                
                switch (input.Key)
                {
                    
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("\nNumPad1");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("\nNumPad2");
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("\nNumPad3");
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("\nNumPad4");
                        break;
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("\nNumPad5");
                        break;
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("\nNumPad6");
                        break;
                    case ConsoleKey.NumPad7:
                        Console.WriteLine("\nNumPad7");
                        break;
                    case ConsoleKey.NumPad8:
                        Console.WriteLine("\nNumPad8");
                        break;
                    case ConsoleKey.NumPad9:
                        Console.WriteLine("\nNumPad9");
                        break;
                    case ConsoleKey.NumPad0:
                        Console.WriteLine("\nNumPad0");
                        flag = false;
                        break;
                    default:
                        break;

                }
            } while (flag == true); // TODO 05.04.2023 2:32  сделал выход из цикла по условию 
        }

    }
}
