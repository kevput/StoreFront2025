using Microsoft.AspNetCore.Mvc;
using StoreFront.Model;

namespace StoreFront
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private static Dictionary<int, Customer> _customers = new() { { 1, new("Gilles", new(2001, 5, 11), "gilles.penen@hogent.com") } };

		[HttpGet]
		public List<Customer> GetCustomers()
		{
			return _customers.Values.ToList();
		}

		[HttpPut]
		public void StoreCustomer([FromBody] Customer customer)
		{
			_customers.Add(_customers.Count + 1, customer);
		}

		[HttpGet("detail")]
		public Customer GetCustomerById([FromQuery] int id)
		{
			return _customers[id];
		}

        [HttpDelete()]
        public void DeleteCustomerById(int id) => _customers.Remove(id);

		[HttpPost()]
		public void UpdateCustomerById(int id, [FromBody] Customer customer) => _customers[id] = customer;
    }
}
