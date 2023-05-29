using MediatR;

namespace Shop.Domain.Querys.GetCustomer
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        public Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            string nome = "Carlos";
            string email = "carlos@teste.com";
            DateTime dataCriacao = DateTime.Now;

            return Task.FromResult(new GetCustomerResponse(request.Id, nome, email, dataCriacao));
        }
    }
}
