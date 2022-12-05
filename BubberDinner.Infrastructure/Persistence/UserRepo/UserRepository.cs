using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace BubberDinner.Infrastructure.Persistence.UserRepo;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public UserRepository()
    {
        // _users.AddRange(new User[]
        // {
        //     User.Create("reza", "shirazi", "shirazi.reza.sh@gmail.com", "welcome123"),
        //     User.Create("ali", "fard", "ali.fard@gmail.com", "welcome123")
        // });
    }

    public Task<User?> GetUserByEmail(string email)
    {
        return Task.FromResult(_users.FirstOrDefault(user => user.Email == email));
    }

    public Task<Guid> Add(User user)
    {
        _users.Add(user);
        return Task.FromResult(user.Id);
    }
}