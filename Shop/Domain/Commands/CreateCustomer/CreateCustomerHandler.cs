using MediatR;

namespace Shop.Domain.Commands.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateCustomerResponse(Guid.NewGuid(), request.Name, request.Email, DateTime.Now));
        }
    }
}
