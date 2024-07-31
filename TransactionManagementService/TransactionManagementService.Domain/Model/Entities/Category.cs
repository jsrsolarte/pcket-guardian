using TransactionManagementService.Domain.Model.Entities.Base;

namespace TransactionManagementService.Domain.Model.Entities;

public abstract class Category(string name, string description) : DomainEntity
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}