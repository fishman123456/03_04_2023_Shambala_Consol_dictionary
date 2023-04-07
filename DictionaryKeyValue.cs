using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    
    public class DictionaryKeyValue
    {
        public List<string> Eng_words { get; set; } = new List<string>();
        public List<string> Rus_words { get; set; } = new List<string>();

        public string retmenu;

        public DictionaryKeyValue() { }
        public DictionaryKeyValue(List<string> engW, List<string> rusW)
        {
            Eng_words = engW;
            Rus_words = rusW;
        }
        // 07-04-2023 22:01 метод добавления русского слова и перевода в словарь
        public void MethodAdd()
        {
            Console.WriteLine("Введите английское слово ");
            string WordEng = Console.ReadLine();
            Console.WriteLine("Введите русское слово ");
            string WordRus = Console.ReadLine();
            // добавление слов в списки
            Eng_words.Add(WordEng);
            Rus_words.Add(WordRus);
            
            // слова добавлены, seriliaze object
            //CreationAndModificationXML creation = new CreationAndModificationXML();
            //creation.SerrializationObject(di);
        }



        // метод для сравнения строк именно английских
        // 04.04.2023 метод сравнения английских слов работает
        public string MethodFindeEngRuss()
        {
            string key = Console.ReadLine();
            foreach (string eng in Eng_words)
            {
                if (String.Compare(eng, key) == 0)
                {
                    Console.WriteLine("Строка " + eng + " и " + " строка " + key + " равны!");
                    return eng;
                }
            }
            foreach (string rus in Rus_words)
            {
                if (String.Compare(rus, key) == 0)
                {
                    Console.WriteLine("Строка " + rus + " и " + " строка " + key + " равны!");
                    return rus;
                }
            }
            Console.WriteLine("Нет совпадений");
            return "";
        }
        // todo функция для возвращения из меню что делать input, add, change, delete
        // потом реализуем методы, поиск готов, осталось добавить в список, в автомате русск (англ) слово
        // изменить русск (англ) слово, удалить 
        public static string ReturnMenu(string st)
        {
            //  прописать функцию для поиска введенного слова, уже есть и на русском и на английсском
            if (st == "input") { Console.WriteLine("найти"); }
            // прописать функцию для добавления нескольких слов (англ) и переводов (русск) , создать обьект
            if (st == "add") { Console.WriteLine("добавить"); }
            // прописать ф-ю для десерриализации, поиска слова (англ/русск) и изменения (англ\русск) 
            if (st == "chenge") { Console.WriteLine("изменить"); }
            // прописать ф-ю для удаления слова, т.е. обьекта
            if (st == "delete") { Console.WriteLine("удалить"); }
            return st;
        }

        //  TODO:  04-04-2023 15:24 Написал перегрузку метода вывода обьекта класса в строку 
        public override string ToString()
        {
            foreach (string eng in Eng_words) { Console.WriteLine(eng); }
            foreach (string rus in Rus_words) { Console.WriteLine(rus); }
            //return ("English " + Eng_words.ToString() +"\t" + "Russian " + Rus_words.ToString());
            return "";
        }
    }
}
