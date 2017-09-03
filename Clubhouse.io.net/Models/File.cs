using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class File
    {
        public string ContentType { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Description { get; set; }

        public string EntityType { get; set; }

        public string ExternalID { get; set; }

        public string Filename { get; set; }

        public long ID { get; set; }

        public List<Guid> MentionIDs { get; set; }

        public string Name { get; set; }

        public long Size { get; set; }

        public List<long> StoryIDs { get; set; }

        public string ThumbnailURL { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid UploaderID { get; set; }

        public string Url { get; set; }
    }
}