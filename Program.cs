using Person.Data;
using Person.Routes;

var builder = WebApplication.CreateBuilder(args);

// Serviços necessários para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();
app.UseHttpsRedirection();
app.Run();