using System;

namespace Assignment2.Model
{
    public class Address
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }

        public override string ToString()
        {
            return string.Format(
                    "{0}, {1}, {2}, {3} - {4}",
                    street,
                    city,
                    state,
                    country,
                    postcode
                );
        }
    }
}