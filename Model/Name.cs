using System;

namespace Assignment2.Model
{
    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }

        public override string ToString()
        {
            return string.Format(
                "{0} {1} {2}",
                title,
                first,
                last);
        }
    }
}