using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities.Epics
{
    public enum ClubhouseEpicState
    {
        [EnumMember(Value = "to do")]
        ToDo,
        [EnumMember(Value = "in progress")]
        InProgress,
        [EnumMember(Value = "done")]
        Done
    }
}