using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.CreateCustomer;
using Shop.Domain.Commands.GetCustomer;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> CreateCustomer([FromBody]CreateCustomerRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpGet]
        [Route("")]
        public async Task<GetCustomerResponse> GetCustomer(Guid id)
        {
            var request = new GetCustomerRequest(id);
            return await _mediator.Send(request);
        }
    }
}
