using Domain.DBEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEntity
    {
        EntityStatus Status { get; set; }
    }
}
