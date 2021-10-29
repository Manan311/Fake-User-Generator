namespace Assignment2.Model
{
    public class ResultObject
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public Address location { get; set; }
        public string email { get; set; }
        public Login login { get; set; }
        public DOB dob { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Picture picture { get; set; }
    }

    public class DOB
    {
        public string date { get; set; }
    }
}