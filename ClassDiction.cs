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
        public List<DictionaryKeyValue> dictions = new List<DictionaryKeyValue>();
        public void AddObject(DictionaryKeyValue obj)
        {
            dictions.Add(obj);
        }


        // Серриализация списка обьектов
        //public void SerrializationObject() // TODO xml создан всё идет по плану 05-04-2023 3:32 кумитим и спать
        //{
        //    //  var serializer = new XmlSerializer(typeof(DictionaryKeyValue));
        //    /// XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryKeyValue>), null, CollectTypesFromCollection(config), new XmlRootAttribute("Classes"), "");
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryKeyValue>), null, 
        //        new Type[] { typeof(List<DictionaryKeyValue>) },
        //        new XmlRootAttribute(""), "");

        //    using (var writer = new StreamWriter("DictionaryCreateXML.xml"))
        //    {
        //        serializer.Serialize(writer, dictions);
        //        Console.WriteLine("Serrializ");
        //    }
        //}
        // для понимания серриализации множества обьектов одного типа пользовательского класса
        //private static Type[] CollectTypesFromCollection(List<DictionaryKeyValue> collection)
        //{
        //    List<Type> types = new List<Type>();
        //    foreach (DictionaryKeyValue item in collection)
        //        if (!types.Contains(item.GetType()))
        //            types.Add(item.GetType());
        //    return types.ToArray();
        //}
        public void SerrializationObject()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<DictionaryKeyValue>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("DictionaryCreateXML.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dictions);
            }
        }
        public void DeserrializationObject()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<DictionaryKeyValue>));
            using (FileStream fs = new FileStream("DictionaryCreateXML.xml", FileMode.OpenOrCreate))
            {
                List<DictionaryKeyValue> engruswords = formatter.Deserialize(fs) as List<DictionaryKeyValue>;

                if (engruswords != null)
                {
                    foreach (DictionaryKeyValue words in engruswords)
                    {
                        Console.WriteLine($"English : {words.Eng_words} --- Russian: {words.Rus_words}");
                    }
                }
            }
        }
    }
}
        // Десерриализация списка обьектов
    //    public void DeserrializationObject()
    //    {
    //        dictions.Clear();

    //        XmlSerializer formatter = new XmlSerializer(typeof(List<DictionaryKeyValue>));

    //        // восстановление массива из файла
    //        using (FileStream fs = new FileStream("DictionaryCreateXML.xml", FileMode.OpenOrCreate))
    //        {
    //            DictionaryKeyValue desdict = formatter.Deserialize(fs) as DictionaryKeyValue;

    //            // вывод на консоль информации из файйла
    //            if (desdict != null)
    //            {
    //                Console.WriteLine("Deserialize\n");
    //                foreach (var s in desdict.Eng_words)
    //                {
    //                    Console.WriteLine(s);
    //                }
    //            }
    //        }
    //    }
    //}

//static public void SerializeIT(string filename, object toSerialize)
//{
//    XmlSerializer xmlFormat = new XmlSerializer(toSerialize.GetType());
//    using (Stream fStream = File.Create(filename))
//    {
//        xmlFormat.Serialize(fStream, toSerialize);
//    }
//    WriteLine("Serialized!\n");
//}
//static public T DeserializeIT<T>(string filename)
//{
//    XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
//    using (Stream fStream = File.OpenRead(filename))
//    {
//        T obj = (T)xmlFormat.Deserialize(fStream);
//        return obj;
//    }
//}