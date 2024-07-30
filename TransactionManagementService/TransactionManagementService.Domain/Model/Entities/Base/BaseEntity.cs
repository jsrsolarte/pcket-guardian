using System;

namespace TransactionManagementService.Domain.Model.Entities.Base;

public abstract class BaseEntity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; protected set; } = DateTime.UtcNow;

    protected void SetUpdatedTimestamp()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}