using System.ComponentModel;

namespace Domain.DBEnums
{
    public enum EntityStatus
    {
        [Description("Delete")]
        Delete = 0,

        [Description("New")]
        New = 1,
    }
}
