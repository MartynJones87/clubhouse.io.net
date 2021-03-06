﻿using System;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Epics
{
    public class ClubhouseCreateEpicCommentParams
    {
        [JsonProperty(PropertyName = "author_id")]
        public Guid AuthorID { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}