namespace WebAppAPI.Model.Entities
{
    public class Employee
    {
        public Guid Id { get; set; } // Guid is a unique identifier
        public required string Name { get; set; }
        public required string Email { get; set; } // required means it is mandatory
        public string? Phone { get; set; } // ? means nullable that means it can be null
        public decimal Salary { get; set; }

    }
}
