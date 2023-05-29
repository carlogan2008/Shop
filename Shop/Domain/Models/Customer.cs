namespace Shop.Domain.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Customer(Guid id, string name, string email, DateTime date)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
        }
    }
}
