﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtMetod
{
    public static class StringExtension
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        public static char Cezar(this char ch)
        {
            ch = (char)(ch + 3);
            return ch;
        }
        /*public static char Cezar(this char ch, char symb)
        {
            symb = (char)(ch + 3);
            return ch;
        }*/

        internal class Program
        {
            static void Main(string[] args)
            {
                for (int i = (int)'A'; i <= (int)'Z'; i++)
                {

                    Console.Write($"{(char)i} код {i} " + /*$"{(char)(i + 32)} код {i + 32} " +*/ $"{(char)(i + 3)} код {i + 3} \n");
                }
                Console.WriteLine("============================");
                string text = "Дооообрый день! ооо", text02 = "";
                char symb = 'о';
                Console.WriteLine($"В {text} " +
                    $"символ {symb} " +
                    $"встречается {text.CharCount(symb)} раз");
                char tmp;

                for (int i = 0; i < text.Length; i++)
                {
                    tmp = text[i].Cezar();
                    text02 += tmp;
                }
                Console.WriteLine($"{text} = {text02}");
                Console.ReadKey();
            }
        }
    }
}
