using MediatR;

namespace Shop.Domain.Commands.CreateCustomer
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateCustomerRequest(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
