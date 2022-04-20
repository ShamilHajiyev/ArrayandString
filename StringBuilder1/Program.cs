using System;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(FirstToUpper(sentence));
        }
        public static string FirstToUpper(string sentence)
        {
            sentence = sentence.ToLower();
            string[] words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                else
                {
                    words[i] = Convert.ToString(char.ToUpper(words[i][0]));
                }
            }
            string newSentence = string.Join(' ', words);
            return newSentence;
        }
    }
}
