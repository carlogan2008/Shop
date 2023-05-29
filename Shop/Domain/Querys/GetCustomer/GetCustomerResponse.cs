using Shop.Domain.Models;

namespace Shop.Domain.Querys.GetCustomer
{
    public class GetCustomerResponse : Customer
    {
        public GetCustomerResponse(Guid id, string name, string email, DateTime date) : base(id, name, email, date)
        {
        }
    }
}
