using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Categories
{
    public class ClubhouseUpdateCategoryParams
    {
        [JsonProperty(PropertyName = "archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}