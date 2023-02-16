/*
Here's an example C# code to replace a word in a directory and all of its subdirectories and files:

Do you look up all files in all subdirectories under subdirectories in the code?

Yes, that's correct. In the provided code, the GetFiles method is called with the SearchOption.AllDirectories option,
which will recursively search for files in all subdirectories of the specified directory, as well as subdirectories of any subdirectories,
and so on. This ensures that all files in the specified directory and its subdirectories will be found and processed.
*/
using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        string directoryPath = @"C:\example\directory";
        string searchWord = "oldWord";
        string replaceWord = "newWord";
        ReplaceInDirectory(directoryPath, searchWord, replaceWord);
    }

    static void ReplaceInDirectory(string directoryPath, string searchWord, string replaceWord) {
        foreach (string filePath in Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories)) {
            string fileText = File.ReadAllText(filePath);
            fileText = fileText.Replace(searchWord, replaceWord);
            File.WriteAllText(filePath, fileText);
        }
    }
}

