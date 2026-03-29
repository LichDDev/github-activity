using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.Models
{
    public class GithubEvent
    {
        public string? id { get; set; }
        public string? type { get; set; }
        public Actor? actor { get; set; }
        public Repo? repo { get; set; }
        public Payload? payload { get; set; }
        public bool? @public { get; set; }
        public DateTime created_at { get; set; }
    }
}
