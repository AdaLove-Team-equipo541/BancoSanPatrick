using SanPatrick.Application.UseCases.User.Authenticate;
using FluentAssertions;
using Xunit;

namespace SanPatrick.Application.Tests.UseCases.User.Authenticate;

public class AuthenticateUserCommandTest
{
    [Fact]
    public void AuthenticateUserCommand_HasRequiredFields_Test()
    {
        // Arrange
        const string email = "test@test.com";
        const string password = "Test_123";
        const string ipAddress = "192.0.0.1";
        var authenticateUserCommand = new AuthenticateUserCommand(
            email, 
            password, 
            ipAddress);
        
        // Act
        
        // Assert
        authenticateUserCommand.Email.Should().Be(email);
        authenticateUserCommand.Password.Should().Be(password);
        authenticateUserCommand.IpAddress.Should().Be(ipAddress);
    }
}