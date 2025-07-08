using MoviesApi.Application.Services;
using MoviesApi.Infrastructure;
using MoviesApi.Persistence.Repositories;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AccountRepository>();
builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<JwtService>();

builder.Services.Configure<AuthSettings>(
    builder.Configuration.GetSection("AuthSettings"));

builder.Services.AddAuth(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
