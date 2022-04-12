using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Domains
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        public int Amount { get; set; }
        public int Year { get; set; }
        public int Percent { get; set; }
        public PersonStatus Status { get; set; }
        public int Supportness { get; set; }
    }

    public enum PersonStatus
    {
        GoodCustomer,
        BadCustomer,
        ModerateCustomer
    }
}