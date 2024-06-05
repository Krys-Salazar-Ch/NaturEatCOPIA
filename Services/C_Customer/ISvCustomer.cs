using Entities;

namespace Services.C_Customer
{
    public interface ISvCustomer
    {
        public Customer Add_Customer(Customer customer);

        public List<Customer> GetAllCustomers();
    }
}