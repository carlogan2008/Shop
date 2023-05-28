using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.CreateCustomer;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest request)
        {
            return mediator.Send(request);
        }
    }
}
