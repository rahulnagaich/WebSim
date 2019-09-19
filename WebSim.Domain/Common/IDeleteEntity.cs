using System;

namespace WebSim.Domain.Common
{
    public interface IDeleteEntity
    {
        bool IsDeleted { get; set; }

        Guid? DeletedBy { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}