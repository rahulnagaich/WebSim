using System;

namespace WebSim.Domain.Common
{
    public interface IUpdateEntity
    {
        Guid? LastModifiedBy { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}