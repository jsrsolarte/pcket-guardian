using TransactionManagementService.Domain.Model.Enums;

namespace TransactionManagementService.Domain.Model.Entities;

public class CreditCardAccount(
    Guid userId,
    string accountName,
    decimal balance,
    decimal creditLimit,
    decimal availableCredit,
    DateTime billingCycleDate)
    : FinancialAccount(userId, accountName, balance)
{
    public decimal CreditLimit { get; private set; } = creditLimit;
    public decimal AvailableCredit { get; private set; } = availableCredit;
    public DateTime BillingCycleDate { get; private set; } = billingCycleDate;

    protected override void UpdateBalance(decimal amount, TransactionType transactionType)
    {
        //TODO: Implementación específica para las tarjetas de crédito para actualizar el balance y el crédito disponible
    }
}