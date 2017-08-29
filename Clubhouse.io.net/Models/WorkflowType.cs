using System.ComponentModel;

namespace Clubhouse.io.net.Models
{
    public enum WorkflowType
    {
        [Description("Unstarted")]
        Unstarted,
        [Description("Started")]
        Started,
        [Description("Finished")]
        Finished
    }
}