using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    internal class ClassDiction
    {
        //создание списка обьектов
        public List <DictionaryKeyValue> dictions = new List<DictionaryKeyValue>();

        // добавление обьекта
        public void AddObject(DictionaryKeyValue obj)
        {
            dictions.Add(obj);
        }

        // поиск и удаление строк
        public void MethodDeleteEngRuss() // 
        {
            DictionaryKeyValue ob = new DictionaryKeyValue();
            Console.WriteLine("Введите слово для удаления\\изменения ");
            var str = Console.ReadLine();
            foreach (DictionaryKeyValue obj2 in dictions)
            {
                if (obj2.Eng_words.Contains(str) || (obj2.Rus_words.Contains(str)))
                {
                    Console.WriteLine("Удаляем слово и перевод!");
                    dictions.Remove(obj2);
                    Console.WriteLine("Слово удалено!");
                    break;
                }
            }
        }



        ////// Серриализация списка обьектов
        // метод для сравнения строк именно английских
        // 04.04.2023 метод сравнения английских слов работает
        public void MethodFindEngRuss() // надо передать список обьектов по которому будем искать совпадения
        {
            DictionaryKeyValue ob = new DictionaryKeyValue();
            Console.WriteLine("Введите искомое слово");
            var str  = Console.ReadLine();  
            foreach (DictionaryKeyValue obj2 in dictions)
            {
               if (obj2.Eng_words.Contains(str) || (obj2.Rus_words.Contains(str)))
                {
                    Console.WriteLine("Есть такое слово!");
                    Console.WriteLine(obj2.ToString());
                }   
            }
        }
        public void Ser()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List <DictionaryKeyValue>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("Dictionary.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dictions);
            }
        }
        ////// Десерриализация списка обьектов с выводом на консоль

        public void Deser()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<DictionaryKeyValue>));
            // восстановление массива из файла
            using (FileStream fs = new FileStream("Dictionary.xml", FileMode.OpenOrCreate))
            {
                 dictions = formatter.Deserialize(fs) as List<DictionaryKeyValue>;

                if (dictions != null)
                {
                    foreach (DictionaryKeyValue words in dictions)
                    {
                        foreach (char str in words.ToString())
                        {
                            //Console.WriteLine($"English: {Convert.ToString(words.Eng_words)} --- Russian: {words.Rus_words.ToString()}");
                        }
                       
                    }
                }
               
            }
            
        }
       
    }
}


    

     
