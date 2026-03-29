using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using github_activity.Models;

namespace github_activity.Services
{
    public class GithubService(HttpClient _client) : IGithubService
    {
        public async Task<IEnumerable<GithubEvent>> GetUserActivity(string username)
        {
            var response = await _client.GetStringAsync($"users/{username}/events");

            var events = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<GithubEvent>>(response);
            
            return events;
        }
    }
}
