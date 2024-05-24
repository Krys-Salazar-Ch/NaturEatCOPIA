using Entities;
using Services.C_Categories;
using Services.C_Order_Confirmation;
using Services.C_Customer;
using Services.C_Product;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddScoped<ISvCustomer, SvCustomer>();
builder.Services.AddScoped<ISvOrder, SvOrder_Confirmation>();
builder.Services.AddScoped<ISvProduct, SvProduct>();
builder.Services.AddScoped<ISvCategories, SvCategories>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
