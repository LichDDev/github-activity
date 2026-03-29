using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.Services
{
    interface IGithubService
    {
        public Task<IEnumerable<GithubEvent>> GetUserActivity(string username);
    }
}
