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
        public void AddObject(DictionaryKeyValue obj)
        {
            dictions.Add(obj);
        }
        ////// Серриализация списка обьектов
        // метод для сравнения строк именно английских
        // 04.04.2023 метод сравнения английских слов работает
        public void MethodFindEngRuss(List<DictionaryKeyValue> dictions) // надо передать список обьектов по которому будем искать совпадения
        {
            Console.WriteLine("Введите искомое слово");
            var str  = Console.ReadLine();  
            foreach (DictionaryKeyValue obj in dictions)
            {
               if (((str != null)&&(obj.Eng_words.Contains(str)) || (obj.Rus_words.Contains(str))))
                {
                    Console.WriteLine("Английское слово" + obj.Eng_words + " " + "Русское слово " + obj.Rus_words);
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
                List<DictionaryKeyValue> NewWords = formatter.Deserialize(fs) as List<DictionaryKeyValue>;

                if (NewWords != null)
                {
                    foreach (DictionaryKeyValue words in NewWords)
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


    

     
