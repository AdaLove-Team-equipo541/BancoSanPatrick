using MediatR;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.SavingsAccounts.Commands.CreateSavingsAccountCommand
{
    public class CreateSavingsAccountCommand : IRequest<Response<Guid>>
    {
        public string Alias { get; set; } = String.Empty;
    }
}
