using System;
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
            ClassDiction classDiction = new ClassDiction();

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
                        //classDiction.Deser();
                        classDiction.MethodFindEngRuss();

                        break;
                    case ConsoleKey.NumPad2:
                          Console.WriteLine("\nДобавление слова в словарь\n");
                        // DictionaryKeyValue.ReturnMenu("add");
                        DictionaryKeyValue keyValue = new DictionaryKeyValue();
                        keyValue.MethodAdd();
                        classDiction.AddObject(keyValue);
                        classDiction.Ser();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("\nСчитывание из файла");
                        //Console.WriteLine("Введите имя файла");
                        //string filename = Console.ReadLine();
                        classDiction.Deser();
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("\nУдаление слова из словаря");
                        classDiction.MethodDeleteEngRuss();
                        classDiction.Ser();
                        break;
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("\nСохранить в файл");
                        classDiction.Ser();
                        break;
                    //case ConsoleKey.NumPad6:
                    //    Console.WriteLine("\nNumPad6");
                    //    break;
                    //case ConsoleKey.NumPad7:
                    //    Console.WriteLine("\nNumPad7");
                    //    break;
                    //case ConsoleKey.NumPad8:
                    //    Console.WriteLine("\nNumPad8");
                    //    break;
                    ////case ConsoleKey.NumPad9:
                    ////    System.Threading.Thread.Sleep(500);// пауза в 1 секунду
                       
                    ////    Console.WriteLine("Файл очищен");
                    ////    break;
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
            Console.WriteLine("\tNumPad0. Для выхода из программы"); // работает
            Console.WriteLine("\tNumPad1. Поиск перевода ");
            Console.WriteLine("\tNumPad2. Добавление слова в словарь "); // работает
            Console.WriteLine("\tNumPad3. Считывание из файла"); // работает
            Console.WriteLine("\tNumPad4. Удаление слова из словаря");
            Console.WriteLine("\tNumPad5. Сохранить в файл");// работает
            //Console.WriteLine("6. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("7. Добавление слова в словарь (нажмите для ввода слова)\n");
            //Console.WriteLine("8. Добавление слова в словарь (нажмите для ввода слова)\n");
           // Console.WriteLine("\t9. Стереть файл\n");
        }
    }
}
