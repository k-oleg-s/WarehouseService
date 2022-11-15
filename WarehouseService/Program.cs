
using WarehouseService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IItemRepository, ItemRepo>();
builder.Services.AddScoped<IItemGroupRepository, ItemGroupRepo>();
builder.Services.AddScoped<ILocationRepository, LocationRepo>();
builder.Services.AddScoped<IStockRepository, StockRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
