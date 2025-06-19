var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
    // This partial class is used to allow for additional configurations or methods
    // to be added in other files without modifying this main Program.cs file.
}
