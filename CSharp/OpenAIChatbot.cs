using System;
using System.Net.Http;
using System.Threading.Tasks;

public class OpenAI
{
    private const string API_BASE_URL = "https://api.openai.com/v1/";
    private readonly string apiKey;

    public OpenAI(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public async Task<string> GetCompletion(string prompt, string chatLog)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var data = new
        {
            prompt = prompt,
            max_tokens = 50,
            temperature = 0.5,
            n = 1,
            stop = "\n",
            context = chatLog
        };

        var response = await client.PostAsJsonAsync($"{API_BASE_URL}engines/davinci-codex/completions", data);
        var result = await response.Content.ReadAsStringAsync();

        return result;
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        // Replace YOUR_API_KEY with your actual OpenAI API key
        var openai = new OpenAI("YOUR_API_KEY");

        var chatLog = "";
        while (true)
        {
            Console.Write("You: ");
            var prompt = Console.ReadLine();

            chatLog += $"You: {prompt}\nAI: ";

            var response = await openai.GetCompletion(prompt, chatLog);

            chatLog += response.Trim() + "\n";
            Console.WriteLine($"AI: {response}\n");
        }
    }
}
