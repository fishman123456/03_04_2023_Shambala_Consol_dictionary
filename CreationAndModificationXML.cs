using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
