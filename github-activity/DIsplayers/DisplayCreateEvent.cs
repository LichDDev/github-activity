using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.DIsplayers
{
    public class DisplayCreateEvent : IDisplay
    {
        public GithubEvent Data { get; set; }

        public DisplayCreateEvent(GithubEvent activity)
        {
            Data = activity;
        }

        public void showActivity()
        {
            var repoName = Data?.repo?.name ??"nada";
          
            if (!string.IsNullOrEmpty(Data?.payload?.ref_type))
                Console.WriteLine($"Created {Data.payload.ref_type} in {repoName}");
            else
                Console.WriteLine($"Created something in {repoName}");
        }
    }
}
