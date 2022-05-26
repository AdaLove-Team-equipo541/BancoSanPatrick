using MediatR;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.SavingsAccount.Commands.CreateSavingsAccountCommand
{
    public class CreateSavingsAccountCommandHandler : IRequestHandler<CreateSavingsAccountCommand, Response<Guid>>
    {
        public Task<Response<Guid>> Handle(CreateSavingsAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
