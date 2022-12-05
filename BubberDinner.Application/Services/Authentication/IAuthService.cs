namespace BubberDinner.Application.Services.Authentication;

public interface IAuthService
{
    Task<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    Task<AuthenticationResult> Login(string email, string password);
}