using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.LinkedFiles
{
    public class ClubhouseUpdateLinkedFileParams
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

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