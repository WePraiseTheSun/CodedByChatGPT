using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task CloneFolderAsync(string sourceFolderPath, string targetFolderPath, string folderName, int maxDegreeOfParallelism = -1)
    {
        string sourceFolderName = Path.GetFileName(sourceFolderPath);
        string targetFolderName = Path.GetFileName(targetFolderPath);

        if (sourceFolderName.Equals(folderName, StringComparison.InvariantCultureIgnoreCase))
        {
            Directory.CreateDirectory(targetFolderPath);

            var fileTasks = new List<Task>();
            foreach (string file in Directory.GetFiles(sourceFolderPath))
            {
                string targetFilePath = Path.Combine(targetFolderPath, Path.GetFileName(file));
                fileTasks.Add(Task.Run(() => File.Copy(file, targetFilePath, true)));
            }
            await Task.WhenAll(fileTasks);

            var subfolderTasks = new List<Task>();
            foreach (string subfolder in Directory.GetDirectories(sourceFolderPath))
            {
                string subfolderName = Path.GetFileName(subfolder);
                string targetSubfolderPath = Path.Combine(targetFolderPath, subfolderName);
                subfolderTasks.Add(CloneFolderAsync(subfolder, targetSubfolderPath, folderName, maxDegreeOfParallelism));
            }
            await Task.WhenAll(subfolderTasks);
        }
    }

    static async Task Main(string[] args)
    {
        string sourceFolderPath = @"C:\path\to\source\folder";
        string targetFolderPath = @"C:\path\to\target\folder";
        string folderName = "myfolder";
        int maxDegreeOfParallelism = -1;

        await CloneFolderAsync(sourceFolderPath, targetFolderPath, folderName, maxDegreeOfParallelism);

        Console.WriteLine("Done!");
        Console.ReadLine();
    }
}
