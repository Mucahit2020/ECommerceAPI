using ECommerce.Application.Products;
using ECommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();               // Controller'lar
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Application
builder.Services.AddScoped<IProductService, ProductService>();

// Infrastructure (DbContext + Repo + UoW)
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseAuthorization(); // Ýleride auth eklersen aç

app.MapControllers();

app.Run();
