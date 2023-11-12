using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using VMorales.Booking.Application.Configuration;
using VMorales.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using VMorales.Booking.Application.DataBase.Customer.Commands.DeleteCustomer;
using VMorales.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetAllCustomers;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetCustomerById;
using VMorales.Booking.Application.DataBase.User.Commands.CreateUser;
using VMorales.Booking.Application.DataBase.User.Commands.DeleteUser;
using VMorales.Booking.Application.DataBase.User.Commands.UpdateUser;
using VMorales.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using VMorales.Booking.Application.DataBase.User.Queries.GetAllUser;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserById;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;

namespace VMorales.Booking.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            #region User
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
            services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
            services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
            services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
            services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
            services.AddTransient<IGetUserByUserNameAndPasswordQuery, GetUserByUserNameAndPasswordQuery>();
            #endregion

            #region Customer
            services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
            services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
            services.AddTransient<IGetAllCustomerQuery, GetAllCustomerQuery>();
            services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();
            #endregion
            return services;
        }
    }
}
