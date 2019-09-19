using System;

namespace WebSim.Domain.Common
{
    public interface ICreateEntity
    {
        Guid CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }
    }
}