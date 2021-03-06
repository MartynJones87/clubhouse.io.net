﻿using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseIdentity
    {
        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
