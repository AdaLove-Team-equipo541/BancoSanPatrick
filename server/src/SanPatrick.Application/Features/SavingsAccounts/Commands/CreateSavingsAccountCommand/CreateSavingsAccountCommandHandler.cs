using AutoMapper;
using MediatR;
using SanPatrick.Application.Interfaces;
using SanPatrick.Application.Wrappers;
using SanPatrick.Domain.Entities;

namespace SanPatrick.Application.Features.SavingsAccounts.Commands.CreateSavingsAccountCommand
{
    public class CreateSavingsAccountCommandHandler : IRequestHandler<CreateSavingsAccountCommand, Response<Guid>>
    {
        private readonly IRepositoryAsync<SavingsAccount> _repository;
        private readonly IMapper _mapper;

        public CreateSavingsAccountCommandHandler(IRepositoryAsync<SavingsAccount> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<Guid>> Handle(CreateSavingsAccountCommand request, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<SavingsAccount>(request);

            var data = await _repository.AddAsync(record);

            return new Response<Guid>(data.Id);
        }
    }
}
