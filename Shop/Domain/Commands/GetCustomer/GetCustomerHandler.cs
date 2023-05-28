using MediatR;

namespace Shop.Domain.Commands.GetCustomer
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        public Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            string nome = "Carlos";
            string email = "carlos@teste.com";
            DateTime dataCriacao = DateTime.Now;

            return Task.FromResult(new GetCustomerResponse(Guid.NewGuid(), nome, email, dataCriacao));
        }
    }
}
