using MediatR;
using TransactionManagementService.Domain.Accounts.Enums;

namespace TransactionManagementService.Application.Accounts.Commands;

public record CreateBankAccountCommand(Guid UserId, string AccountName, decimal Balance, AccountType AccountType)
    : IRequest<Guid>;