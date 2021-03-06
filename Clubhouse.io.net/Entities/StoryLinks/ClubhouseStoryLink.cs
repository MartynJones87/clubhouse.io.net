﻿using System;
using Clubhouse.io.net.Entities.Stories;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.StoryLinks
{
    public class ClubhouseStoryLink
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "object_id")]
        public long ObjectID { get; set; }

        [JsonProperty(PropertyName = "subject_id")]
        public long SubjectID { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "verb")]
        public ClubhouseStoryVerbs Verb { get; set; }
    }
}