using System.ComponentModel;

namespace Clubhouse.io.net.Models
{
    public enum State
    {
        [Description("to do")]
        ToDo,
        [Description("in progress")]
        InProgress,
        [Description("done")]
        Done
    }
}