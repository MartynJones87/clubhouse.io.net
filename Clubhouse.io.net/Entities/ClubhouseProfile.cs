using Newtonsoft.Json;

namespace Clubhouse.io.net.Entities
{
    public class ClubhouseProfile
    {
        [JsonProperty(PropertyName = "deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty(PropertyName = "display_icon")]
        public ClubhouseIcon DisplayIcon { get; set; }

        [JsonProperty(PropertyName = "email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName = "gravatar_hash")]
        public string GravatarHash { get; set; }

        [JsonProperty(PropertyName = "mention_name")]
        public string MentionName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "two_factor_auth_activated")]
        public bool TwoFactorAuthActivated { get; set; }
    }
}
