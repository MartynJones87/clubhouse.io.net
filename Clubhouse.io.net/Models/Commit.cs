using System;
using System.Collections.Generic;

namespace Clubhouse.io.net.Models
{
    public class Commit
    {
        public string AuthorEmail { get; set; }

        public Guid? AuthorID { get; set; }

        public Identity AuthorIdentity { get; set; }

        public DateTime CreatedAt { get; set; }

        public string EntityType { get; set; }

        public string Hash { get; set; }

        public long? ID { get; set; }

        public List<long> MergedBranchIDs { get; set; }

        public string Message { get; set; }

        public long? RepositoryID { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Url { get; set; }
    }
}
