using Microsoft.EntityFrameworkCore;
using VMorales.Booking.Application.DataBase;
using VMorales.Booking.Domain.Entities.Booking;
using VMorales.Booking.Domain.Entities.Customer;
using VMorales.Booking.Domain.Entities.User;
using VMorales.Booking.Persistence.Configuration;

namespace VMorales.Booking.Persistence.DataBase
{
    public class DataBaseService: DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options): base(options) 
        {

        }

        public DbSet<UserEntity> User { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<BookingEntity> Booking { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
        }
    }
}
