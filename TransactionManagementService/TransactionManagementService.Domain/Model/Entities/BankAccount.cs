using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public class BankAccount(Guid userId, string accountName, decimal balance, AccountType accountType)
    : FinancialAccount(userId, accountName, balance)
{
    public AccountType AccountType { get; private set; } = accountType;

    protected override void UpdateBalance(decimal amount, TransactionType transactionType)
    {
        //TODO: Implementación específica para las cuentas bancarias para actualizar el balance
    }
}