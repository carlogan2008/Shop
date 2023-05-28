namespace Shop.Domain.Commands.GetCustomer
{
    public class GetCustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public GetCustomerResponse(Guid id, string name, string email, DateTime date)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
        }
    }
}
