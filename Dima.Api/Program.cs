using Dima.Api.Data;
using Dima.Api.Handlers;
using Dima.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);
builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    x => x.CustomSchemaIds(n => n.FullName)
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.Run();
