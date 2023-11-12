using Microsoft.EntityFrameworkCore;
using VMorales.Booking.Domain.Entities.Booking;
using VMorales.Booking.Domain.Entities.Customer;
using VMorales.Booking.Domain.Entities.User;

namespace VMorales.Booking.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
