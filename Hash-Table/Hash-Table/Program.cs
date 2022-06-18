using System;
using static Hash_Table.Repeated;

namespace Hash_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //HashTable Hash = new HashTable();

            //Hash.Set("1", "yousef");
            //Hash.Set("2", "ali");
            //Hash.Set("3", "samara");

            string one = "Once upon a time, there was a brave princess who...";
            string two = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string three = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Console.Write("Example 1 resalt is : ");
            Console.WriteLine(RepeatedWord(one));
            Console.Write("Example 2 resalt is : ");
            Console.WriteLine(RepeatedWord(two));
            Console.Write("Example 3 resalt is : ");
            Console.WriteLine(RepeatedWord(three));
        }

        public static string RepeatedWord(string words)
        {
            HashTable Hash = new HashTable();
            char[] Chars = { ' '};
            string y = words.ToLower();
            string[] x = y.Split(Chars);

            for (int i = 0; i < x.Length; i++)
            {
                if (Hash.Get(x[i]) == null)
                {
                    Hash.Set(x[i], "1");
                }
                else
                    return x[i];
            }
            return "ther is no Repeated Words";
        }


    }
}
