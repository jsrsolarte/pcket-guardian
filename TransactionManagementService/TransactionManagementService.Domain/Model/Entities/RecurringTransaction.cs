using System;
using TransactionManagementService.Domain.Model.Entities.Base;
using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public class RecurringTransaction : DomainEntity
{
    public FinancialAccount Account { get; private set; }
    public Guid AccountId { get; private set; }
    public decimal Amount { get; private set; }
    public TransactionType TransactionType { get; private set; }
    public Category Category { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public RecurrenceFrequency Frequency { get; private set; }
    public string Description { get; private set; }

    public RecurringTransaction(FinancialAccount account, decimal amount, TransactionType transactionType, Category category, DateTime startDate, DateTime? endDate, RecurrenceFrequency frequency, string description)
    {
        Account = account;
        AccountId = account.Id;
        Amount = amount;
        TransactionType = transactionType;
        Category = category;
        StartDate = startDate;
        EndDate = endDate;
        Frequency = frequency;
        Description = description;
    }
}