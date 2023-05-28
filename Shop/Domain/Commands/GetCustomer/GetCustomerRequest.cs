using MediatR;

namespace Shop.Domain.Commands.GetCustomer
{
    public class GetCustomerRequest : IRequest<GetCustomerResponse>
    {
        public Guid Id { get; set; }

        public GetCustomerRequest(Guid id)
        {
            Id = id;
        }
    }
}
