using System;
using System.Text;

namespace Menshakov03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your data: ");
            var data = Console.ReadLine();
            var filtratedData = RemoveNumbers(data);
            Console.WriteLine($"Data after removing numbers: {filtratedData}");
            filtratedData = ReverseOddWords(filtratedData);
            Console.WriteLine($"Data after task one: {filtratedData}");
            filtratedData = FirstCharToUpper(filtratedData);
            Console.WriteLine($"Data after task two: {filtratedData}");
            filtratedData = ReplaceLetters(filtratedData);
            Console.WriteLine($"Data after task three: {filtratedData}");
        }

        public static string RemoveNumbers(string text)
        {
            var data = new StringBuilder(text);
            for (int i = 0; i < data.Length; i++)
            {
                if (char.IsDigit(data[i]))
                {
                    data.Remove(i, 1);
                    i--;
                }
            }

            return string.Join(" ", data.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }

        public static string ReverseOddWords(string text)
        {
            var words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    var word = words[i].ToCharArray();
                    Array.Reverse(word);
                    words[i] = new string(word);
                }
            }

            return string.Join(' ', words);
        }

        public static string FirstCharToUpper(string text)
        {
            var words = text.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(' ', words);
        }

        public static string ReplaceLetters(string text)
        {
            var words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith("p", StringComparison.InvariantCultureIgnoreCase))
                {
                    words[i] = "S" + words[i].Substring(1);
                }

                if (words[i].EndsWith("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1) + "O";
                }
            }

            return string.Join(' ', words);
        }
    }
}