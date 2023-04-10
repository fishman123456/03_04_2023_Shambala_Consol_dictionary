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
// для проверки создаем списки
//List<string> list = new List<string>();
//list.Add("first");
//list.Add("second");
//List<string> list2 = new List<string>();
//list2.Add("первый");
//List<string> list3 = new List<string>();
//list3.Add("tree");
//List<string> list4 = new List<string>();
//list4.Add("дерево");
//DictionaryKeyValue one = new DictionaryKeyValue(list, list2);
//Manager_Menu.UserHint();
//DictionaryKeyValue two = new DictionaryKeyValue(list3, list4);
//Console.WriteLine(one);
//Console.WriteLine("введите слова для поиска");
//cr.SerrializationObject(one);
//CreationAndModificationXML cr2 = new CreationAndModificationXML();
//cr.SerrializationObject(two);

//cr2.DeserrializationObject(one);
Manager_Menu.UserMenu();


