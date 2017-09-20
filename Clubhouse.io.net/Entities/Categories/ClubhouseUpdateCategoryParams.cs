using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities.Categories
{
    public class ClubhouseUpdateCategoryParams
    {
        [JsonProperty(PropertyName = "archived")]
        public bool Archived { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}