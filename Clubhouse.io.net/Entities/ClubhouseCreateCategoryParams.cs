using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseCreateCategoryParams
    {
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
