using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.Models
{
    public class Payload
    {
        public int repository_id { get; set; }
        public object? push_id { get; set; }
        public string? @ref { get; set; }
        public string? head { get; set; }
        public string? before { get; set; }
        public string? ref_type { get; set; }
        public string? full_ref { get; set; }
        public string? master_branch { get; set; }
        public object? description { get; set; }
        public string? pusher_type { get; set; }
        public string? action { get; set; }
        public Forkee? forkee { get; set; }
    }
}
