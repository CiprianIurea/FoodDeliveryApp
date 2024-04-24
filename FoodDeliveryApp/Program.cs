using FoodDeliveryApp.DataLayers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FoodDeliveryAppDb>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("FoodDeliveryAppDb")));
var app = builder.Build();

app.Run();
