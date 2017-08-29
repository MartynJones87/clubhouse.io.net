using System.ComponentModel;

namespace Clubhouse.io.net.Models
{
    public enum StoryTypes
    {
        [Description("feature")]
        Feature,
        [Description("chore")]
        Chore,
        [Description("bug")]
        Bug
    }
}