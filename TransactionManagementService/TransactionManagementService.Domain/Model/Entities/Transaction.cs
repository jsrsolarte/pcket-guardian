using System;
using TransactionManagementService.Domain.Model.Entities.Base;
using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public class Transaction(
    Guid accountId,
    decimal amount,
    TransactionType transactionType,
    Category category,
    DateTime date,
    string description)
    : BaseEntity
{
    public Guid AccountId { get; private set; } = accountId;
    public decimal Amount { get; private set; } = amount;
    public TransactionType TransactionType { get; private set; } = transactionType;
    public Category Category { get; private set; } = category;
    public DateTime Date { get; private set; } = date;
    public string Description { get; private set; } = description;
}