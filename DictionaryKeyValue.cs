using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_2023_Shambala_Consol_dictionary
{
    public class DictionaryKeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }

      public  DictionaryKeyValue() { }
      public  DictionaryKeyValue(string key, string value)
        {
           this.Key = key;
           this.Value = value;
        }
        // метод для сравнения строк именно английских
        // 04.04.2023 метод сравнения английских слов работает
        public  string MethodFindeEnglish(string key)
        {
            if (String.Compare(this.Key, key)==0)
            {
                Console.WriteLine("Строка " + this.Key + " и " + " строка " + key + " равны!");
            }
            else 
            {
                Console.WriteLine("Строка " + this.Key + " и " + " строка " + key + " не равны!");
            }
            return ""; 
        }


        //  TODO:  04-04-2023 15:24 Написал перегрузку метода вывода обьекта класса в строку 
        public override string ToString ()
        {
            return ("English " + Key +"\t" + "Russian " + Value);
        }
    }
}
