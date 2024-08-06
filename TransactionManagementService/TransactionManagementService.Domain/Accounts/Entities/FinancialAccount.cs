using TransactionManagementService.Domain.Commons.Entities;
using TransactionManagementService.Domain.Transactions.Entities;
using TransactionManagementService.Domain.Transactions.Enums;

namespace TransactionManagementService.Domain.Accounts.Entities;

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