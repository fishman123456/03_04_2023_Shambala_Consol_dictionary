using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    internal class CreationAndModificationXML
    {
        public void SerrializationObject(object obj) // TODO xml создан всё идет по плану 05-04-2023 3:32 кумитим и спать
        {
            var serializer = new XmlSerializer(typeof(DictionaryKeyValue));
            using (var writer = new StreamWriter("DictionaryCreateXML.xml"))
            {
                serializer.Serialize(writer, obj);
                Console.WriteLine("Serrializ");
            }
        }
        public void DeserrializationObject(object desdict1)
        {
            DictionaryKeyValue  dictionaryKeyValue = new DictionaryKeyValue { };
            XmlSerializer formatter = new XmlSerializer(typeof(DictionaryKeyValue));

            // восстановление массива из файла
            using (FileStream fs = new FileStream("DictionaryCreateXML.xml", FileMode.OpenOrCreate))
            {
                DictionaryKeyValue desdict = formatter.Deserialize(fs) as DictionaryKeyValue;

                if (desdict != null)
                {
                    Console.WriteLine("Deserialize\n");
                    foreach (string s in desdict.Rus_words)
                    {
                        Console.WriteLine($"Руское слово: {desdict.Rus_words} --- Английское слово: {desdict.Eng_words}");
                    }
                }
            }
        }
        }
}
