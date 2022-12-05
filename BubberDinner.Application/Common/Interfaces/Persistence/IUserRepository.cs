using BubberDinner.Domain.Entities;

namespace BubberDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task<User?> GetUserByEmail(string email);
    Task<Guid> Add(User user);
}