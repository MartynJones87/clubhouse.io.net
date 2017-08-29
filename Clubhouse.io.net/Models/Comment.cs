﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class Comment
    {
        [JsonProperty(PropertyName = "author_id")]
        public Guid AuthorID { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "mention_ids")]
        public List<Guid> MentionIDs { get; set; }

        [JsonProperty(PropertyName = "position")]
        public long Position { get; set; }

        [JsonProperty(PropertyName = "story_id")]
        public long StoryID { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
