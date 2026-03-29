using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.DIsplayers
{
    public class DisplayPushEvent : IDisplay
    {
        public GithubEvent Data {get; set; }

        public DisplayPushEvent(GithubEvent data)
        {
            Data = data;
        }

        public void showActivity()
        {
            if (!string.IsNullOrEmpty(Data?.payload?.@ref))
                Console.WriteLine($"Pushed to {Data.payload.@ref} in {Data?.repo?.name}");
            else
                Console.WriteLine($"Pushed to {Data?.repo?.name}");
        }
    }
}
