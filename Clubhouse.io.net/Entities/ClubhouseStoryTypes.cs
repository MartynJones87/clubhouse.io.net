using System.ComponentModel;

namespace Clubhouse.io.net.Entities
{
    public enum ClubhouseStoryTypes
    {
        [Description("feature")]
        Feature,
        [Description("chore")]
        Chore,
        [Description("bug")]
        Bug
    }
}