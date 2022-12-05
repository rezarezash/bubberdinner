using BubberDinner.Application.Common.Interfaces.Authentication;
using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Domain.Entities;

namespace BubberDinner.Application.Services.Authentication;

public class AuthService : IAuthService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthService(IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        // Check if user exists
        if (await _userRepository.GetUserByEmail(email) is User user)
        {
            throw new Exception("user already exists with the provided email");
        }

        // Create user ( hash the password )
        user = User.Create(firstName, lastName, email, password);
        await _userRepository.Add(user);
        
        // Generate token 
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }

    public async Task<AuthenticationResult> Login(string email, string password)
    {
        // Check if user exists
        if (await _userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User does not exists in our system");
        }
        
        // Generate token 
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        // Login the user
        return new AuthenticationResult(user, token);
    }
}