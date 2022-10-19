using System;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Verilen cumleni capitalized formatinda geriye qaytaran bir method yazin.

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("\nCapitalized:");
            Console.WriteLine(FirstToUpper(sentence));
            Console.WriteLine(sentence);
        }
        public static string FirstToUpper(string sentence)
        {
            sentence = sentence.ToLower();
            string[] words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            string newSentence = string.Join(' ', words);
            return newSentence;
        }
    }
}
