using System;

namespace Io
{
    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string Street { get; set; }

        private Address()
        {
        }

        public Address(string compoundAddress)
        {
            var addrParts = compoundAddress.Split(',');
            if (addrParts.Length >= 3)
            {
                Country = addrParts[0];
                State = addrParts[1];
                Street = addrParts[2];
            }

            throw new ArgumentException("Invalid Address");
        }

        public Address(string country, string state, string street)
        {
            Country = country;
            State = state;
            Street = street;
        }

        public override string ToString()
        {
            return $"{Country}, {State}, {Street}";
        }
    }
}