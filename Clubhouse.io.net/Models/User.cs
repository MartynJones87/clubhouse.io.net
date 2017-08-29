using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clubhouse.io.net.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "permissions")]
        public List<Permission> Permissions { get; set; }

        [JsonProperty(PropertyName = "two_factor_auth_activated")]
        public bool TwoFactorAuthenticationActivated { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
    }
}