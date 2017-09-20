using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.LinkedFiles
{
    public class ClubhouseCreateLinkedFileParams
    {
        [JsonProperty(PropertyName = "content_type")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

        [JsonProperty(PropertyName = "story_ids")]
        public List<long> StoryIDs { get; set; }

        [JsonProperty(PropertyName = "thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "uploader_id")]
        public Guid UploaderID { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}