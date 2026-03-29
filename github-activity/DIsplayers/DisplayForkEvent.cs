using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.DIsplayers
{
    public class DisplayForkEvent: IDisplay
    {

        public GithubEvent Data { get; set; }

        public DisplayForkEvent(GithubEvent activity)
        {
            Data = activity;
        }

        public void showActivity()
        {
            string forkee = Data?.payload?.forkee?.Full_name ?? string.Empty;
            var repoName = Data?.repo?.name ?? "unknown repository";

            if (!string.IsNullOrEmpty(forkee))
                Console.WriteLine($"Forked {repoName} to {forkee}");
            else
                Console.WriteLine($"Forked {repoName}");
        }
    }
}
