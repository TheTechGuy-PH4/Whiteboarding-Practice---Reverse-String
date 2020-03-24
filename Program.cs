using System;
using System.Collections.Generic;

namespace Whiteboarding_Practice___Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("How much wood could a woodchuck chuck, if a woodchuck could chuck wood?"));
        }

        public static string Reverse(string s)
        {
            if(s.Length == 0)
            {
                return "String is Empty";
            }
            else
            {
                string[] str = s.Split(" ");
                
                Stack<string> theStack = new Stack<string>();

                string rev = "";
                
                for (int i = 0; i < str.Length; i++)
                {
                    theStack.Push(str[i]);
                }

                while (theStack.Count != 0)
                {
                    rev += " " + theStack.Pop();
                }

                return rev;
            }
        }
    }
}
