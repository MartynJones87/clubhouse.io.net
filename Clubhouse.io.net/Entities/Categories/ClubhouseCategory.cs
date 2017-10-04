using System;
using Clubhouse.io.net.Entities.Workflows;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Clubhouse.io.net.Entities.Categories
{
    public class ClubhouseCategory
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClubhouseCategoryTypes Type { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }


}
}
