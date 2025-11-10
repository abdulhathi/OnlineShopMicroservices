var builder = WebApplication.CreateBuilder(args);

// * Adding DI
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
  config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// * Configure http request pipeline
app.MapCarter();

app.Run();
