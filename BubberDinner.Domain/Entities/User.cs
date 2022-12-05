using System.ComponentModel.DataAnnotations;

namespace BubberDinner.Domain.Entities;

public class User
{
    private User(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null;
    public string LastName { get; set; } = null;
    public string Email { get; set; } = null;
    public string Password { get; set; } = null;

    public static User Create(string firstName, string lastName, string email, string password)
        => new(firstName, lastName, email, password);
}