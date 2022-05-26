using MediatR;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.SavingsAccount.Commands.CreateSavingsAccountCommand
{
    public class CreateSavingsAccountCommand : IRequest<Response<Guid>>
    {
        public string Alias { get; set; }
    }
}
