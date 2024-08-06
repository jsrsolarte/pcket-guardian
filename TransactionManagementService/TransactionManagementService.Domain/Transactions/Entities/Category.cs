using TransactionManagementService.Domain.Commons.Entities;

namespace TransactionManagementService.Domain.Transactions.Entities;

public abstract class Category(string name, string description) : DomainEntity
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}