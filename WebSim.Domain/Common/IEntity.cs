using System;

namespace WebSim.Domain.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}