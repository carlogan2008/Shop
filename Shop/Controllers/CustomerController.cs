using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.CreateCustomer;
using Shop.Domain.Querys.GetCustomer;
using System.Net;

namespace Shop.Controllers
{
    [ApiController]
    [Route("/v1/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<CreateCustomerResponse> CreateCustomer([FromBody]CreateCustomerRequest request)
        {
            var result = _mediator.Send(request);
            HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            return result;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<GetCustomerResponse> GetCustomer([FromRoute] Guid id)
        {
            var request = new GetCustomerRequest(id);
            return await _mediator.Send(request);
        }
    }
}
