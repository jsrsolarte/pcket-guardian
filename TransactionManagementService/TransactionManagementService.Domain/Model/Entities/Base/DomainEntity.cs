using System;

namespace TransactionManagementService.Domain.Model.Entities.Base;

public abstract class DomainEntity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
 
}