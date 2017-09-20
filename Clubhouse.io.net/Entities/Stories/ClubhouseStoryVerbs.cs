using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities.Stories
{
    public enum ClubhouseStoryVerbs
    {
        [EnumMember(Value = "blocks")]
        Blocks,
        [EnumMember(Value = "duplicates")]
        Duplicates,
        [EnumMember(Value = "relates to")]
        RelatesTo
    }
}