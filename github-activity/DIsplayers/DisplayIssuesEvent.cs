using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace github_activity.DIsplayers
{
    public class DisplayIssuesEvent : IDisplay
    {
        public GithubEvent Data { get; set; }
        public DisplayIssuesEvent(GithubEvent data)
        {
            Data = data;
        }
        public void showActivity()
        {
            if (string.Equals(Data?.payload?.action, "opened", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Opened a new issue in {Data?.repo?.name}");
            }
            else if (!string.IsNullOrEmpty(Data?.payload?.action))
            {
                Console.WriteLine($"{Data.payload.action} an issue in {Data?.repo?.name}");
            }
            else
            {
                Console.WriteLine($"Issues event in {Data?.repo?.name}");
            }
        }
    }
}
