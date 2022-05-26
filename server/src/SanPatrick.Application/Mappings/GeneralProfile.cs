using AutoMapper;
using SanPatrick.Application.Features.SavingsAccounts.Commands.CreateSavingsAccountCommand;
using SanPatrick.Domain.Entities;

namespace SanPatrick.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Commands
            CreateMap<CreateSavingsAccountCommand, SavingsAccount>();
            #endregion
        }
    }
}
}
