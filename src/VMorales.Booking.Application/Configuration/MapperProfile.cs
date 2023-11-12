using AutoMapper;
using VMorales.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using VMorales.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetAllCustomers;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using VMorales.Booking.Application.DataBase.Customer.Queries.GetCustomerById;
using VMorales.Booking.Application.DataBase.User.Commands.CreateUser;
using VMorales.Booking.Application.DataBase.User.Commands.UpdateUser;
using VMorales.Booking.Application.DataBase.User.Queries.GetAllUser;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserById;
using VMorales.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using VMorales.Booking.Domain.Entities.Customer;
using VMorales.Booking.Domain.Entities.User;

namespace VMorales.Booking.Application.Configuration
{
    public class MapperProfile: Profile
    {
        public MapperProfile() 
        {
            #region User
            CreateMap<UserEntity, CreateUserModel>().ReverseMap();            
            CreateMap<UserEntity, UpdateUserModel>().ReverseMap();            
            CreateMap<UserEntity, GetAllIUserModel>().ReverseMap();            
            CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();            
            CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            #endregion

            #region Customer
            CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetAllCustomersModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();
            #endregion
        }
    }
}
