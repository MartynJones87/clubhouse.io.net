using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public class ClubhouseMember
    {
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "disabled")]
        public bool Disabled { get; set; }

        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonProperty(PropertyName = "profile")]
        public ClubhouseProfile Profile { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
