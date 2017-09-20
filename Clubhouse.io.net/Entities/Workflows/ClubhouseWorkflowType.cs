using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities.Workflows
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