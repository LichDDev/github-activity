using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.DIsplayers
{
    internal class DisplayWatchEvent : IDisplay
    {
        public GithubEvent Data { get ; set ; }
        
        public DisplayWatchEvent(GithubEvent Data) { 
            this.Data = Data;
        }

        public void showActivity()
        {
            Console.WriteLine($"Starred {Data?.repo?.name}");
        }

    }
}
