using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Stories
{
    public class ClubhouseUpdateTaskParams
    {
        [JsonProperty(PropertyName = "after_id")]
        public long AfterID { get; set; }

        [JsonProperty(PropertyName = "before_id")]
        public long BeforeID { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "owner_ids")]
        public List<Guid> OwnerIDs { get; set; }
    }
}