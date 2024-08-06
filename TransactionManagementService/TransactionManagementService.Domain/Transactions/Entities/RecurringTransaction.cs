using TransactionManagementService.Domain.Accounts.Entities;
using TransactionManagementService.Domain.Commons.Entities;
using TransactionManagementService.Domain.Transactions.Enums;

namespace TransactionManagementService.Domain.Transactions.Entities;

public abstract class RecurringTransaction(
    FinancialAccount account,
    decimal amount,
    TransactionType transactionType,
    Category category,
    DateTime startDate,
    DateTime? endDate,
    RecurrenceFrequency frequency,
    string description)
    : DomainEntity
{
    public FinancialAccount Account { get; private set; } = account;
    public Guid AccountId { get; private set; } = account.Id;
    public decimal Amount { get; private set; } = amount;
    public TransactionType TransactionType { get; private set; } = transactionType;
    public Category Category { get; private set; } = category;
    public DateTime StartDate { get; private set; } = startDate;
    public DateTime? EndDate { get; private set; } = endDate;
    public RecurrenceFrequency Frequency { get; private set; } = frequency;
    public string Description { get; private set; } = description;
}