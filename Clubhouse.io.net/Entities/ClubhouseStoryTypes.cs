using System.ComponentModel;
using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities
{
    public enum ClubhouseStoryTypes
    {
        [EnumMember(Value = "feature")]
        Feature,
        [EnumMember(Value = "chore")]
        Chore,
        [EnumMember(Value = "bug")]
        Bug
    }
}