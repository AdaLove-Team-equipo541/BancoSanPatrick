using FluentAssertions;
using SanPatrick.Application.UseCases.User.Register;
using Xunit;

namespace SanPatrick.Application.Tests.UseCases.User.Register;

public class RegisterUserCommandTest
{
    [Fact]
    public void RegisterUserCommand_HasRequiredFields_Test()
    {
        // Arrange
        const string email = "test@test.com";
        const string password = "Test_123";
        const string confirmPassword = "Test_123";
        const string phoneNumber = "1234566789";
        const string firstName = "Firstname";
        const string middleName = "Middlename";
        const string lastName = "Lastname";
        const string birthDate = "10/12/1990";
        const string avatarString = "url";
        const string citizenship = "col";
        const int maritalStatus = 1;
        const string occupation = "developer";
        const string country = "col";
        const string city = "bog";
        const string address = "add 1";
        const string origin = "origin";
        var registerUserCommand = new RegisterUserCommand(
            email,
            password,
            confirmPassword,
            phoneNumber,
            firstName,
            middleName,
            lastName,
            birthDate,
            avatarString,
            citizenship,
            maritalStatus,
            occupation,
            country,
            city,
            address,
            origin
        );

        // Act
        
        // Assert
        registerUserCommand.Email.Should().Be(email);
        registerUserCommand.Password.Should().Be(password);
        registerUserCommand.ConfirmPassword.Should().Be(confirmPassword);
        registerUserCommand.PhoneNumber.Should().Be(phoneNumber);
        registerUserCommand.FirstName.Should().Be(firstName);
        registerUserCommand.MiddleName.Should().Be(middleName);
        registerUserCommand.LastName.Should().Be(lastName);
        registerUserCommand.BirthDate.Should().Be(birthDate);
        registerUserCommand.AvatarString.Should().Be(avatarString);
        registerUserCommand.Citizenship.Should().Be(citizenship);
        registerUserCommand.MaritalStatus.Should().Be(maritalStatus);
        registerUserCommand.Occupation.Should().Be(occupation);
        registerUserCommand.Country.Should().Be(country);
        registerUserCommand.City.Should().Be(city);
        registerUserCommand.Address.Should().Be(address);
        registerUserCommand.Origin.Should().Be(origin);
    }

    [Fact]
    public void TestFail()
    {
        Assert.True(false); // Test will fail
    }
}