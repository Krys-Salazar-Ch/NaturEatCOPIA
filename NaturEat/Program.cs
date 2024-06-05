using Services.C_Categories;
using Services.C_Order_Confirmation;
using Services.C_Customer;
using Services.C_Product;
using Services.OrderDetail;
using Services.C_SendEmail;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ISvCustomer, SvCustomer>();
builder.Services.AddScoped<ISvOrder, SvOrder_Confirmation>();
builder.Services.AddScoped<ISvProduct, SvProduct>();
builder.Services.AddScoped<ISvCategories, SvCategories>();
builder.Services.AddScoped<ISvOrderDetail, SvOrderDetail>();
builder.Services.AddScoped<ISvSendEmail, SvSendEmail>();


builder.Services.AddControllers()
    .AddNewtonsoftJson(x =>
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

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