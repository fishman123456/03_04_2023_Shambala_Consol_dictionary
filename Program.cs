// See https://aka.ms/new-console-template for more information
// дата создания 04-04-2023
// словарь.
// три класса

//1 Класс (DictionaryKeyValue) - обьект слово перевод. В дальнейшем нагет надо загрузить от яндекса
// поля - один ключ и несколько значений
//2 Класс (SerrToXml) - принимает обьект и сохраняет его в xml, потом считывает его оттуда
// принимает обьект и сохраняет\считывает его из xml файла
//3 Класс (Manager) - интерфейс работы со словарем, swich и прочее
// обработка нажатия клавиш и выбор выполняемой функции

using _03_04_2023_Shambala_Consol_dictionary;

//class Program
//{
//    static void Main(string[] args)
//    {
//        DictionaryKeyValue one ("dd","jt");
//       // one ("red", "красный");
//        Console.WriteLine(one);
//    }

//}

DictionaryKeyValue one = new DictionaryKeyValue("red","красный");

Console.WriteLine(one);
Console.WriteLine("введите слова для поиска");
string ver = Console.ReadLine();
one.MethodFindeEnglish(ver);
Manager_Menu.UserMenu();