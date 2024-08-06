namespace TransactionManagementService.Domain.Commons.Exceptions;

public class BusinessException : Exception
{
    public BusinessException()
    {
    }

    protected BusinessException(string message) : base(message)
    {
    }

    protected BusinessException(string message, Exception innerException) : base(message, innerException)
    {
    }
}