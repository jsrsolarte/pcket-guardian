using TransactionManagementService.Domain.Accounts.Entities;

namespace TransactionManagementService.Domain.Accounts.Ports;

public interface IBankAccountRepository
{
    Task<Guid> AddAsync(BankAccount financialAccount, CancellationToken cancellationToken);
    Task<bool> ExistByNameAsync(Guid userId, string accountName, CancellationToken cancellationToken);
}