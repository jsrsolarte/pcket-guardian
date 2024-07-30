using System;
using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public class DebtAccount(Guid userId, string accountName, decimal balance, decimal totalDebt, decimal remainingDebt)
    : FinancialAccount(userId, accountName, balance)
{
    public decimal TotalDebt { get; private set; } = totalDebt;
    public decimal RemainingDebt { get; private set; } = remainingDebt;

    protected override void UpdateBalance(decimal amount, TransactionType transactionType)
    {
        // Implementación específica para cuentas de deuda para actualizar el balance y la deuda restante
    }
}