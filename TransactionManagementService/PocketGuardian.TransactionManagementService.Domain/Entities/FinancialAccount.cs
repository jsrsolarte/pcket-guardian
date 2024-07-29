using PocketGuardian.TransactionManagementService.Domain.Entities.Base;

namespace PocketGuardian.TransactionManagementService.Domain.Entities;

public abstract class FinancialAccount: EntityBase
{
    public Guid AccountId { get; set; }
    public Guid UserId { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; set; } = 0;
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    public List<RecurringTransaction> RecurringTransactions { get; set; } = new List<RecurringTransaction>(
}