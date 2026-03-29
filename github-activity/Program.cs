
using github_activity.Services;
using System.Net.Http.Json;
using github_activity.Models;
using System.Net.Http.Headers;

//configure http client
var client = new HttpClient();


client.BaseAddress = new Uri("https://api.github.com/");

client.DefaultRequestHeaders.Add("User-Agent", "github-activity-app");

var user = "kamranahmedse";

var service = new GithubService(client);

var a = await service.GetUserActivity(user);
a.ToList().ForEach(e =>
{
    Console.WriteLine($"Event Type: {e.type}");
    Console.WriteLine($"Repository: {e.repo.name}");
    Console.WriteLine($"Created At: {e.created_at}");
});

Console.WriteLine();

