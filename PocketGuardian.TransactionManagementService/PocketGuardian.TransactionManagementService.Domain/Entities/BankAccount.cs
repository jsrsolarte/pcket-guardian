namespace PocketGuardian.TransactionManagementService.Domain.Entities;

public class BankAccount: FinancialAccount
{
    public AccountType AccountType { get; set; }
}