using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hash_Table.HashTable;

namespace Hash_Table
{
    public class Repeated
    {

        public string RepeatedWord(string text)
        {
            // Get the length
            int n = text.Length;
            if (n == 0)
            {
                return "No text provided";
            }
            HashTable Hash = new HashTable();

            // Collecting words
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] str = text.ToLower().Split(delimiterChars);
            // frequency of given word

            for (int i = 0; i < str.Length; i++)
            {
                if (Hash.Get(str[i]) == null)
                {
                    Hash.Set(str[i], "1");
                }
                else
                    return str[i];
            }
            return "No Repetetion";
        }

    }
}
