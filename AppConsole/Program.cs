// See https://aka.ms/new-console-template for more information
/*string GeneratorUid()
{
    return Guid.NewGuid()
        .ToString()
        .ToUpper()
        .Substring(0,8);
}

Console.WriteLine($"UID {GeneratorUid()}"); */
using System;
using System.Net.Http;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        using var response = await client.GetAsync("http://example.com");
        using var content = response.Content;
        string result = await content.ReadAsStringAsync();
        Console.WriteLine(result);
    }
}

