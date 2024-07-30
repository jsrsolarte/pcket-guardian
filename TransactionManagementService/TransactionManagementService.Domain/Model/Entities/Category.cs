using TransactionManagementService.Domain.Model.Entities.Base;

namespace TransactionManagementService.Domain.Model.Entities;

public class Category(string name, string description) : BaseEntity
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}