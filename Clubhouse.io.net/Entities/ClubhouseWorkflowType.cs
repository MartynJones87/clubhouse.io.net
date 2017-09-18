using System.ComponentModel;
using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities
{
    public enum ClubhouseWorkflowType
    {
        [EnumMember(Value = "unstarted")]
        Unstarted,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "done")]
        Done
    }
}