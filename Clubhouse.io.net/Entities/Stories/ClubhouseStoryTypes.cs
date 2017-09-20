using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities.Stories
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