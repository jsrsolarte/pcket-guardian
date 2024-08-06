using TransactionManagementService.Domain.Commons.Exceptions;

namespace TransactionManagementService.Domain.Accounts.Exceptions;

public sealed class AccountAlreadyExistException: BusinessException
{
    public AccountAlreadyExistException(string message) : base(message)
    {
    }
    
    public AccountAlreadyExistException(string message, Exception innerException) : base(message, innerException)
    {
    }
    
    public AccountAlreadyExistException() : base("Account already exists")
    {
    }
}