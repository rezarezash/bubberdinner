using BubberDinner.Application;
using BubberDinner.Application.Services.Authentication;
using BubberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    // Add dependencies
    builder.Services.AddApplication()
                    .AddInfrastructure();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
