using System;
//using System.Collections.Generic;
using System.Diagnostics;
//using stack_queue_brackets;
//using Stack;

namespace stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(validatebBrackets("()[]{}"));
            Console.WriteLine(validatebBrackets("()[[test]]"));
            Console.WriteLine(validatebBrackets("(){}[[]]"));
            Console.WriteLine(validatebBrackets("([({}]"));
            Console.WriteLine(validatebBrackets("()()()(){}{}[][][]"));
            Console.WriteLine(validatebBrackets("{(})"));
            Console.WriteLine(validatebBrackets("(]("));
            Console.WriteLine(validatebBrackets(null));



        }
        public static bool validatebBrackets(string value)
        {
            Stack stack = new Stack();
            if (value == null)
            {
                return true;
            }

            char first = value[0];
            if (first == ')' || first == ']' || first == '}')
            {
                return false;
            }

            foreach (var item in value)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                }

                if (item == ')' || item == ']' || item == '}')
                {

                    char close = (char)stack.Peek();
                    if( item == ')' && close == '(' || item == ']' && close == '[' || item == '}' && close == '{')
                    {
                        stack.Pop();
                        //return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            if (stack.IsEmpty() == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
