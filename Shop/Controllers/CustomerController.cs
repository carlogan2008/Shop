using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.CreateCustomer;

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
        public Task<CreateCustomerResponse> GetCustomer([FromBody] CreateCustomerRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
