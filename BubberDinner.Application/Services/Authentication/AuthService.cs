namespace BubberDinner.Application.Services.Authentication;

public class AuthService : IAuthService
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "Reza", "Shirazi", "Email", "token-register");
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "Reza", "Shirazi", "Email","token-login");
    }
}