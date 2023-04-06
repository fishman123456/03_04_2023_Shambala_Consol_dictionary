﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    public class Manager_Menu
    {
        
        public static void UserMenu()
        {
            #region
            bool flag = true;
            do
            {
                Console.WriteLine("\tНажмите на клавишу для выбора действия");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.NumPad0:
                        Console.WriteLine("\n Exit");
                        System.Threading.Thread.Sleep(1000);// пауза в 1 секунду
                        flag = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("\nПоиск перевода введите слово");
                        DictionaryKeyValue.ReturnMenu("input");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("\nДобавление слова в словарь");
                        DictionaryKeyValue.ReturnMenu("add");
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("\nИзменение слова в словаре");
                        DictionaryKeyValue.ReturnMenu("change");
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("\nУдаление слова из словаря");
                        DictionaryKeyValue.ReturnMenu("delete");
                        break;
                    //case ConsoleKey.NumPad5:
                    //    Console.WriteLine("\nNumPad5");
                    //    break;
                    //case ConsoleKey.NumPad6:
                    //    Console.WriteLine("\nNumPad6");
                    //    break;
                    //case ConsoleKey.NumPad7:
                    //    Console.WriteLine("\nNumPad7");
                    //    break;
                    //case ConsoleKey.NumPad8:
                    //    Console.WriteLine("\nNumPad8");
                    //    break;
                    //case ConsoleKey.NumPad9:
                    //    System.Threading.Thread.Sleep(500);// пауза в 1 секунду
                    //    Console.Clear();
                    //    UserHint();
                    //    break;
                    default:
                        Console.WriteLine("\tНажмите клавишу из меню\n");
                        System.Threading.Thread.Sleep(500);// пауза в 1 секунду
                        Console.Clear();
                        UserHint();
                        break;
                }
            } while (flag == true); // TODO 05.04.2023 2:32  сделал выход из цикла по условию 
            #endregion
        }
        public static void UserHint() // todo 05-04-2023 подсказка для пользователя
        {
            Console.WriteLine("\n Программа Англорусский / Русскоанглийский словарь\n ");
            Console.WriteLine("\tNumPad0. Для выхода из программы");
            Console.WriteLine("\tNumPad1. Поиск перевода (нажмите для ввода слова)");
            Console.WriteLine("\tNumPad2. Добавление слова в словарь (нажмите для ввода слова)");
            Console.WriteLine("\tNumPad3. Изменение слова в словаре (нажмите для ввода слова)");
            Console.WriteLine("\tNumPad4. Удаление слова из словаря (нажмите для ввода слова)");
            //Console.WriteLine("5. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("6. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("7. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("8. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("\t9. Вывод меню (нажмите для вывода меню)\n");
        }
    }
}
