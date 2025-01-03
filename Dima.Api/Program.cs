using Dima.Api.Data;
using Dima.Api.Endpoints;
using Dima.Api.Handlers;
using Dima.Api.Models;
using Dima.Core.Handlers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddIdentityCookies();
builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);

builder.Services.AddIdentityCore<User>()
    .AddRoles<IdentityRole<long>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddApiEndpoints();

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    x => x.CustomSchemaIds(n => n.FullName)
);

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", () => new { message = "OK" });
app.MapEndpoints();
app.Run();
