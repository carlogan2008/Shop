namespace Shop.Domain.Commands.CreateCustomer
{
    public class CreateCustomerResponse
    {
        public Guid Id { get; set; }

        public CreateCustomerResponse(Guid id)
        {
            Id = id;
        }
    }
}
