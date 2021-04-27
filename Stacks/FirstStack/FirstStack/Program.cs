﻿using System;
using System.Collections;


namespace FirstStack
{
    // All stack methods here https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.stack?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {



        }
        public static void infixToPostfix(string infixText)
        {

            Stack stack = new Stack();
            string postFix = "";
            char temp;
            bool parenthesis = false;

            for (int i = 0; i < infixText.Length; i++)
            {

                if (infixText[i] == '+' || infixText[i] == '-')
                {
                    stack.Push(infixText[i]);
                    continue;
                }
                if (infixText[i] == '(')
                {
                    while (stack.Count != 0)
                    {
                        postFix += stack.Pop();
                    }
                    postFix += '(';

                    parenthesis = true;
                    continue;
                }
                if (infixText[i] == ')' && parenthesis == true)
                {

                    while (stack.Count != 0)
                    {
                        postFix += stack.Pop();
                    }

                    postFix += ')';

                    parenthesis = false;
                    continue;
                }
                if (stack.Count > 0)
                {
                    if (infixText[i] == '^')
                    {
                        while (stack.Count != 0)
                        {
                            postFix += stack.Pop();
                        }
                        continue;
                    }
                    if (infixText[i] == '*' || infixText[i] == '/')
                    {
                        temp = (char)stack.Peek();
                        stack.Push(infixText[i]);

                        if (temp != '^')
                        {
                            while (stack.Count != 0)
                            {
                                postFix += stack.Pop();
                            }
                            continue;
                        }
                    }

                }
                if (((int)infixText[i] >= 65 && (int)infixText[i] <= 90)
                || ((int)infixText[i] >= 97 && (int)infixText[i] <= 122))
                {
                    postFix += infixText[i];
                    continue;
                }
            }
            while (stack.Count > 0)
            {
                postFix += stack.Pop();
            }

            Console.WriteLine(postFix);


        }
        public static void prefixToPostfix(string prefixText) { }
        public static string reverseString(string text)
        {
            Stack stack = new Stack();
            string reverseString = "";

            for (int i = 0; i < text.Length; i++)
            {
                stack.Push(text[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                reverseString += stack.Pop();
            }
            return reverseString;
        }

        public static Stack deleteMiddleValue(Stack stack)
        {
            int length = stack.Count;
            var temp = object;
            Stack stack2 = new Stack();
                
        
            if (length % 2 == 0)
            {
                for (int i = 0; i < length/2; i++)
                {
                    temp = stack.Pop();
                    stack2 += temp;
                }

            }
            else { 
            
            
            }


    
        }
    }
    
}
