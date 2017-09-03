using System;
using System.Collections.Generic;
using System.Text;

namespace Clubhouse.io.net.Models
{
    public class Comment
    {
        public Guid AuthorID { get; set; }

        public DateTime CreatedAt { get; set; }

        public long ID { get; set; }

        public List<Guid> MentionIDs { get; set; }

        public long Position { get; set; }

        public long StoryID { get; set; }

        public string Text { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
