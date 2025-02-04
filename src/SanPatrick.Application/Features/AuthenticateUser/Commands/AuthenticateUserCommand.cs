﻿using MediatR;
using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.Interfaces;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.UseCases.User.Authenticate
{
    public record AuthenticateUserCommand(
        string Email,
        string Password,
        string IpAddress
    ) : IRequest<Response<AuthenticationResponse>>;
        
    public class AuthenticateUserCommandHandler : IRequestHandler<AuthenticateUserCommand, Response<AuthenticationResponse>>
    {
        private readonly IAccountService _accountService;

        public AuthenticateUserCommandHandler(IAccountService accountService) => _accountService = accountService;
        
        public async Task<Response<AuthenticationResponse>> Handle(
            AuthenticateUserCommand request, 
            CancellationToken cancellationToken)
        {
            return await _accountService.AuthenticateAsync(
                new AuthenticationRequest // TODO: Should be immutable?
                {
                Email = request.Email,
                Password = request.Password
                }
                , request.IpAddress);
        }
    }
}
