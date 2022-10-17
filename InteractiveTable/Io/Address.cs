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