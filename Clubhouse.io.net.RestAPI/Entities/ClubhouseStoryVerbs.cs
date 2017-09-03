using System.ComponentModel;

namespace Clubhouse.io.net.RestAPI.Entities
{
    public enum ClubhouseStoryVerbs
    {
        [Description("blocks")]
        Blocks,
        [Description("duplicates")]
        Duplicates,
        [Description("relates to")]
        RelatesTo
    }
}