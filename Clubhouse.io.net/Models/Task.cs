using System;
using System.Collections.Generic;

namespace Clubhouse.io.net.Models
{
    public class Task
    {
        public bool Complete { get; set; }

        public DateTime? CompletedAt { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Description { get; set; }

        public string EntityType { get; set; }

        public string ExternalID { get; set; }

        public long ID { get; set; }

        public List<Guid> MentionIDs { get; set; }

        public List<Guid> OwnerIDs { get; set; }

        public long Position { get; set; }

        public long StoryID { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}