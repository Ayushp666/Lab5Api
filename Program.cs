var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.


    app.UseSwagger();
    app.UseSwaggerUI();

app.MapGet("/hello", () => "Hello from your Azure API running .NET 9");
app.MapGet("/", () => "Lab5Api is running. Go to swagger");
app.UseHttpsRedirection();




app.Run();
