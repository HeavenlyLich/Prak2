using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string s1 = "sasssdeerrfdrgjsoi";
        int s2 = 123456789;
        string s3 = "aasd poda chaaaar promt";
        string s4 = "bla bla abra kadabra bro brat hello hello world";

        Console.WriteLine($"1. Максимальна кількість послідовних символів\n '{s1}': \n {MaxConsecutiveChars(s1)}");
        Console.WriteLine($"2. Вставити пробіли\n '{s2}':\n {InsertSpaces(s2.ToString())}");
        Console.WriteLine($"3. Слово з найбільшою кількістю голосних\n '{s3}':\n {WordWithMostVowels(s3)}");
        Console.WriteLine($"4. Нове речення без дублікатів\n '{s4}':\n {RemoveDuplicateWords(s4)}");
    }

    public static int MaxConsecutiveChars(string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;

        int max = 0;
        int current = 1;
        char previousChar = str[0];

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == previousChar)
            {
                current++;
            }
            else
            {
                if (current > max)
                {
                    max = current;
                }

                previousChar = str[i];
                current = 1;
            }
        }

        return Math.Max(max, current);
    }

    public static string InsertSpaces(string str)
    {
        var reversedStr = new string(str.Reverse().ToArray());
        var sb = new StringBuilder();

        for (int i = 0; i < reversedStr.Length; i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                sb.Append(' ');
            }

            sb.Append(reversedStr[i]);
        }

        var result = new string(sb.ToString().Reverse().ToArray());
        return result;
    }

    public static string WordWithMostVowels(string sentence)
    {
        var words = sentence.Split(' ');
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        string resultWord = null;
        int maxVowels = 0;

        foreach (var word in words)
        {
            int vowelCount = word.Count(c => vowels.Contains(c));

            if (vowelCount > maxVowels)
            {
                maxVowels = vowelCount;
                resultWord = word;
            }
        }

        return resultWord;
    }

    public static string RemoveDuplicateWords(string sentence)
    {
        var words = sentence.Split(' ');
        var wordCounts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        var resultSentence = string.Join(" ", wordCounts.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key));

        return resultSentence;
    }

}
