﻿using System;
using System.Collections;


namespace FirstStack
{
    // All stack methods here https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.stack?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {
            string testInfixString = "a-b--++(+c*d)+g//";
            Console.WriteLine(testInfixString);
            infixToPostfix(testInfixString);
        }

        public static void infixToPostfix(string infixText)
        {

            Stack stack = new Stack();
            string postFix = "";
            char temp;
            bool parenthesis = false;

            for (int i = 0; i < infixText.Length; i++)
            {
                if (((int)infixText[i] >= 65 && (int)infixText[i] <= 90)
                    || ((int)infixText[i] >= 97 && (int)infixText[i] <= 122))
                {
                    postFix += infixText[i];
                    continue;
                }
                if (infixText[i] == '+' || infixText[i] == '-' || infixText[i] == '(')
                {
                    stack.Push(infixText[i]);
                    if (infixText[i] == '(') {
                        parenthesis = true;
                    }
                    continue;
                }
                if (infixText[i] == ')')
                {
                    while ((char)stack.Peek() != '(') 
                    {
                        postFix += stack.Pop();
                    }
                    postFix += stack.Pop();
                    parenthesis = false;
                    continue;
                }
                if (stack.Count > 0 && parenthesis == false)
                {
                    if (infixText[i] == '^' )
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
                else
                {
                    stack.Push(infixText[i]);
                }
                postFix += infixText[i];
            }

            Console.WriteLine(postFix);


        }
    }
}
