using Shop.Domain.Models;
using FluentAssertions;
using Faker;

namespace ShopTest.Shop.UnitTests
{
    public class CustomerTest
    {
        [Fact]
        public void Constructor_Should_Create()
        {
            //Arrange
            Guid id = Guid.NewGuid();
            string name = Name.FullName(NameFormats.WithPrefix);
            string email = Internet.Email().ToLower();
            DateTime date = DateTime.Now;

            //Act
            var customer = new Customer(id, name, email, date);

            //Assert
            customer.Name.Should().Be(name);
        }
    }
}
