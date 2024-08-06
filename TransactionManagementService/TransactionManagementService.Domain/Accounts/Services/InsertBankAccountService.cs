using TransactionManagementService.Domain.Accounts.Entities;
using TransactionManagementService.Domain.Accounts.Enums;
using TransactionManagementService.Domain.Accounts.Exceptions;
using TransactionManagementService.Domain.Accounts.Ports;

namespace TransactionManagementService.Domain.Accounts.Services;

public class InsertBankAccountService(IBankAccountRepository bankAccountRepository)
{
    public async Task<Guid> ExecuteAsync(Guid userId, string accountName, decimal balance, AccountType accountType,
        CancellationToken cancellationToken)
    {
        if (await bankAccountRepository.ExistByNameAsync(userId, accountName, cancellationToken))
        {
            throw new AccountAlreadyExistException();
        }

        var bankAccount = new BankAccount(userId, accountName, balance, accountType);
        return await bankAccountRepository.AddAsync(bankAccount, cancellationToken);
    }
}