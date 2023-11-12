
using VMorales.Booking.Api;
using VMorales.Booking.Api.External;
using VMorales.Booking.Application;
using VMorales.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using VMorales.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using VMorales.Booking.Application.DataBase.User.Commands.CreateUser;
using VMorales.Booking.Application.DataBase.User.Commands.DeleteUser;
using VMorales.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using VMorales.Booking.Application.DataBase.User.Queries.GetAllUser;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserById;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using VMorales.Booking.Common;
using VMorales.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);
// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseAuthorization();

//app.MapControllers();

app.MapPost("/testService", async(IUpdateCustomerCommand service) =>
{
    var model = new UpdateCustomerModel
    {
        CustomerId = 3,
        FullName = "Customer 333",
        DocumentNumber = "33334444"
    };
    return await service.Execute(model);
});

app.Run();
