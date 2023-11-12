
namespace VMorales.Booking.Application.DataBase.Customer.Queries.GetAllCustomers
{
    public interface IGetAllCustomerQuery
    {
        Task<List<GetAllCustomersModel>> Execute();
    }
}
