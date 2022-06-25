using System;
using System.Collections.Generic;
using static Hash_Table.Repeated;
using System.Threading.Tasks;
using System.Collections;

namespace Hash_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable Hash = new HashTable();

            Hash.Set("1", "yousef");
            Hash.Set("2", "ali");
            Hash.Set("3", "samara");
            Console.WriteLine("Repeated Word");
            string one = "Once upon a time, there was a brave princess who...";
            string two = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string three = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Console.Write("Example 1 resalt is : ");
            Console.WriteLine(RepeatedWord(one));
            Console.Write("Example 2 resalt is : ");
            Console.WriteLine(RepeatedWord(two));
            Console.Write("Example 3 resalt is : ");
            Console.WriteLine(RepeatedWord(three));
            Console.WriteLine("****************************************************");
            HashTable left = new HashTable();
            left.Set("diligent", "employed");
            left.Set("fond", "enamored");
            left.Set("guide", "usher");
            left.Set("outift", "garb");
            left.Set("wrath", "anger");

            HashTable right = new HashTable();
            right.Set("diligent", "idle");
            right.Set("fond", "averse");
            right.Set("guide", "follow");
            right.Set("flow", "jam");
            right.Set("wrath", "delight");

            Console.WriteLine("LeftJoin");
            Program LeftJoin = new Program();
            List<string> keys = new List<string>();
            keys = Program.LeftJoin(left, right);
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************************")
;           Console.WriteLine("Tree Intersection");
            Tree mytree = new Tree();
            mytree.Add(6);
            mytree.Add(9);
            mytree.Add(5);
            mytree.Add(3);
            mytree.Add(77);
            Tree mytree2 = new Tree();
            mytree2.Add(4);
            mytree2.Add(2);
            mytree2.Add(6);
            mytree2.Add(3);
            mytree2.Add(44);


            List<int> common = new List<int>();
            common = TreeIntersection(mytree, mytree2);
            Console.WriteLine("intersections are: ");
            foreach (int value in common)
            {
                Console.Write(value + " ");
            }

        }

        
        public static List<int> TreeIntersection(Tree Treeone, Tree Treetwo)
        {
            //if (Treeone.Root == null || Treetwo.Root == null)
            //{
            //    throw new Exception("Tree is empty");
            //}

            List<int> one = new List<int>();
            List<int> two = new List<int>();
            HashTable Hash = new HashTable();
            List<int> common = new List<int>();

            one = Treeone.Order(Treeone.Root);
            two = Treetwo.Order(Treetwo.Root);

            foreach (int value in one)
            {
                BTNode node = new BTNode(value);
                Hash.Set(node.Value.ToString(), node.Value.ToString());
            }
            foreach (int value in two)
            {
                if (Hash.Contains(value.ToString()))
                {
                    common.Add(value);
                }
            }
            return common;
        }

        public static string RepeatedWord(string words)
        {
            HashTable Hash = new HashTable();
            char[] Chars = { ' ' };
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

        public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            List<string> Table = new List<string>();

            for (int i = 0; i < left.node.Length; i++)
            {
                if (left.node[i] != null)
                {
                    Node current = left.node[i];
                    Node L = left.node[i];
                    Node R = right.node[i];

                    while (current != null)
                    {
                        string HOlder = null;
                        HOlder = HOlder + ("[" + L.Key + ":" + $"{L.Value}");

                        if (right.Contains(current.Key))
                        {

                            HOlder = HOlder + ("," + $"{R.Value}" + "]");
                        }
                        else
                        {

                            HOlder += ",NULL]";
                        }
                            Table.Add(HOlder);
                            L = L.Next;
                            current = current.Next;
                        }
                    }
                }
                return Table;
            }
        }


    }
    

