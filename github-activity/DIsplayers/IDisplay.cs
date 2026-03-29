using github_activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.DIsplayers
{
    public interface IDisplay
    {
        GithubEvent Data { get; set; }

        void showActivity();
    }
}
