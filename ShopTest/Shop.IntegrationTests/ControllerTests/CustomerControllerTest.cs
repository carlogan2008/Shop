using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Shop.Domain.Commands.CreateCustomer;
using Shop.Domain.Querys.GetCustomer;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ShopTest.Shop.IntegrationTests.ControllerTests
{
    public class CustomerControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly string _url = "v1/customers";
        private readonly HttpClient _httpClient;

        public CustomerControllerTest() 
        {
            var webFactory = new WebApplicationFactory<Program>();
            _httpClient = webFactory.CreateDefaultClient();
        } 

        [Fact]
        public async void PostCustomer_WithAValidValue_return_Created()
        {
            //arrange
            StringContent content = CreateCustomerContent();

            //act
            var response = await _httpClient.PostAsync(_url, content);

            // Assert
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async void GetCustomer_WithAValidValue_return_Ok()
        {
            //arrange
            Guid id = Guid.NewGuid();
            string url = $"{_url}/{id}";
            string name = "Carlos";

            //act
            var response = await _httpClient.GetAsync(url);
            var stringResult = await response.Content.ReadAsStringAsync();
            var listResponse = JsonConvert.DeserializeObject<GetCustomerResponse>(stringResult);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(name, listResponse?.Name);
        }

        private static StringContent CreateCustomerContent()
        {
            string name = "Carlos";
            string email = "carlos@teste.com";
            var request = new CreateCustomerRequest(name, email);
            var json = JsonConvert.SerializeObject(request);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}