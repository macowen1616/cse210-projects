using System;

namespace Foundation2
{
    public class Address
    {
        private string street;
        private string city;
        private string stateOrProvince;
        private string country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            this.street = street;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        public string GetStreet() => street;
        public string GetCity() => city;
        public string GetStateOrProvince() => stateOrProvince;
        public string GetCountry() => country;

        public bool IsInUSA()
        {
            return country.Trim().ToUpper() == "USA" || country.Trim().ToUpper() == "UNITED STATES";
        }

        public override string ToString()
        {
            return $"{street}\n{city}, {stateOrProvince}\n{country}";
        }
    }
}