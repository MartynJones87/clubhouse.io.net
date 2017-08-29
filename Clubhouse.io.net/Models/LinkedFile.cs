using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class LinkedFile
    {
        [JsonProperty(PropertyName = "content_type")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "mention_ids")]
        public List<Guid> MentionIDs { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        [JsonProperty(PropertyName = "story_ids")]
        public List<int> StoryIDs { get; set; }

        [JsonProperty(PropertyName = "thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "uploader_id")]
        public Guid UploaderID { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}