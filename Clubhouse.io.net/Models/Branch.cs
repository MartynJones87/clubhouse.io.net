using System;
using System.Collections.Generic;

namespace Clubhouse.io.net.Models
{
    public class Branch
    {
        public DateTime? CreatedAt { get; set; }

        public bool Deleted { get; set; }

        public string EntityType { get; set; }

        public long? ID { get; set; }

        public List<long> MergedBranchIDs { get; set; }

        public string Name { get; set; }

        public bool Persistent { get; set; }

        public List<PullRequest> PullRequests { get; set; }

        public long? RepositoryID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Url { get; set; }
    }
}
