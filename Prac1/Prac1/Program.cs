using Prac1;
using System.Net.Http;
using System.Text.Json;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicaiton/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".Net Foundation Repository Reporter");

var repo = await ProcessRepositories(client);

foreach (var rep in repo)
{
    Console.WriteLine($"Name: {rep.Name}");
}

    static async Task<List<Repository>> ProcessRepositories(HttpClient client){
    await using Stream stream = await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
    var repo = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
    return repo ?? new();
}