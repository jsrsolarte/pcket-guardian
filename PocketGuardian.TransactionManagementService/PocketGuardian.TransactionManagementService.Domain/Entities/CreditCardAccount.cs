namespace PocketGuardian.TransactionManagementService.Domain.Entities;

public class CreditCardAccount : FinancialAccount
{
    public decimal CreditLimit { get; set; }
    public decimal AvailableCredit
    {
        get { return CreditLimit - Balance; }
    }
    public DateTime BillingCycleDate { get; set; }
}