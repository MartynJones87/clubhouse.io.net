using System;

namespace Clubhouse.io.net.Models
{
    public class PullRequest
    {
        public long BranchID { get; set; }

        public bool Closed { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string EntityType { get; set; }

        public long ID { get; set; }

        public int NumberAdded { get; set; }

        public int NumberCommits { get; set; }

        public int NumberModified { get; set; }

        public int NumberRemoved { get; set; }

        public int Number { get; set; }

        public int TargetBranchID { get; set; }

        public string Title { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Url { get; set; }
    }
}
