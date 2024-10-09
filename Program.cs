using System;
using System.Collections.Generic;

namespace MorseCodeTranslator
{

    namespace Translator
    {

        public static class MorseCodeDictionary
        {
            private static Dictionary<char, string> codeMap = new Dictionary<char, string>()
            {
                {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."},
                {'f', "..-."}, {'g', "--."}, {'h', "...."}, {'i', ".."}, {'j', ".---"},
                {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n', "-."}, {'o', "---"},
                {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"},
                {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"},
                {'z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
                {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
                {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {' ', "/"}
            };


            public static string ToMorse(char character)
            {
                if (codeMap.ContainsKey(char.ToLower(character)))
                {
                    return codeMap[char.ToLower(character)];
                }
                else
                {
                    return "";
                }
            }
        }


        public class MorseCodeConverter
        {

            public static string Translate(string text)
            {
                string morseCode = "";
                foreach (char character in text)
                {
                    morseCode += MorseCodeDictionary.ToMorse(character) + " ";
                }
                return morseCode.Trim();
            }
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
            string text = Console.ReadLine();

            string morseCode = Translator.MorseCodeConverter.Translate(text);

            Console.WriteLine($"Азбука Морзе: {morseCode}");
            Console.ReadKey();
        }
    }
}