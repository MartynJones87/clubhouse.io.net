using System.Runtime.Serialization;

namespace Clubhouse.io.net.Entities.Milestones
{
    public enum ClubhouseMilestoneStatesType
    {
        [EnumMember(Value = "to do")]
        ToDo,
        [EnumMember(Value = "in progress")]
        InProgress,
        [EnumMember(Value = "done")]
        Done
    }
}