namespace Assignment2.Model
{
    public class Street
    {
        public int number { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format(
                    "{0}, {1}",
                    number,
                    name
                );
        }
    }
}