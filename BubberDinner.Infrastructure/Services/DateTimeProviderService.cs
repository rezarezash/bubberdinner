using BubberDinner.Application.Common.Interfaces;

namespace BubberDinner.Infrastructure.Services;

public class DateTimeProviderService : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}