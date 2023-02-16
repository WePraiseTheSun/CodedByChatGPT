using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog.";
        string[] replacements = { "red", "orange", "yellow", "green", "blue", "purple" };

        int replacementIndex = 0;
        string output = Regex.Replace(input, @"\b\w+\b", match => {
            string replacement = replacements[replacementIndex % replacements.Length];
            replacementIndex++;
            return replacement;
        });

        Console.WriteLine(output);
    }
}