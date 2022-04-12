namespace TestApp
{
    public class PersonPost
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int Amount { get; set; }
        public int Year { get; set; }
        public int Percent { get; set; }
        public int Status { get; set; }
        public int Supportness { get; set; }
    }
}