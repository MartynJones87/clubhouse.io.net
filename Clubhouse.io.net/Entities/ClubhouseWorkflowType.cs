using System.ComponentModel;

namespace Clubhouse.io.net.Entities
{
    public enum ClubhouseWorkflowType
    {
        [Description("Unstarted")]
        Unstarted,
        [Description("Started")]
        Started,
        [Description("Finished")]
        Finished
    }
}