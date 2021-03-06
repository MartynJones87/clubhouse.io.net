﻿using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Labels
{
    public class ClubhouseCreateLabelParams
    {
        [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
