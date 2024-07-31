using TransactionManagementService.Domain.Model.Entities.Base;
using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public abstract class FinancialAccount(Guid userId, string accountName, decimal balance) : DomainEntity
{
    private readonly List<RecurringTransaction> _recurringTransactions = [];
    private readonly List<Transaction> _transactions = [];

    public Guid UserId { get; private set; } = userId;
    public string AccountName { get; private set; } = accountName;
    public decimal Balance { get; private set; } = balance;
    public IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();
    public IReadOnlyCollection<RecurringTransaction> RecurringTransactions => _recurringTransactions.AsReadOnly();

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        UpdateBalance(transaction.Amount, transaction.TransactionType);
    }

    public void AddRecurringTransaction(RecurringTransaction recurringTransaction)
    {
        _recurringTransactions.Add(recurringTransaction);
    }

    protected abstract void UpdateBalance(decimal amount, TransactionType transactionType);
}