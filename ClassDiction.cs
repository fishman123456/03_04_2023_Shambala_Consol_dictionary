using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    internal class ClassDiction
    {
        //создание списка обьектов
        public List<DictionaryKeyValue> dictions = new List<DictionaryKeyValue>();
        public void AddObject(DictionaryKeyValue obj)
        {
            dictions.Add(obj);
        }


        // Серриализация списка обьектов
        public void SerrializationObject() // TODO xml создан всё идет по плану 05-04-2023 3:32 кумитим и спать
        {
            //  var serializer = new XmlSerializer(typeof(DictionaryKeyValue));
            /// XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryKeyValue>), null, CollectTypesFromCollection(config), new XmlRootAttribute("Classes"), "");
            XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryKeyValue>), null, new Type[] { typeof(List<DictionaryKeyValue>) },
                new XmlRootAttribute(""), "");

            using (var writer = new StreamWriter("DictionaryCreateXML.xml"))
            {
                serializer.Serialize(writer, dictions);
                Console.WriteLine("Serrializ");
            }
        }
        // для понимания серриализации множества обьектов одного типа пользовательского класса
        private static Type[] CollectTypesFromCollection(List<DictionaryKeyValue> collection)
        {
            List<Type> types = new List<Type>();
            foreach (DictionaryKeyValue item in collection)
                if (!types.Contains(item.GetType()))
                    types.Add(item.GetType());
            return types.ToArray();
        }

        // Десерриализация списка обьектов
        public void DeserrializationObject()
        {
            dictions.Clear();

        XmlSerializer formatter = new XmlSerializer(typeof(List<DictionaryKeyValue>));

            // восстановление массива из файла
            using (FileStream fs = new FileStream("DictionaryCreateXML.xml", FileMode.OpenOrCreate))
            {
                DictionaryKeyValue desdict = formatter.Deserialize(fs) as DictionaryKeyValue;

                // вывод на консоль информации из файйла
                if (desdict != null)
                {
                    Console.WriteLine("Deserialize\n");
                    foreach (var s in desdict.Eng_words)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
