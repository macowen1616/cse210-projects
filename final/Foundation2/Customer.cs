using System;
namespace Foundation2
{
    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName() => name;
        public Address GetAddress() => address;

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }
    }
}