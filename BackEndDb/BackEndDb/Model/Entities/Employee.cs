namespace BackEndDb.Model.Entities
{
    public class Employee
    {
        public Guid Id { get; set; } //Guid is a 128-bit integer that is globally unique
        public required string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }  //? means nullable(accepts null values)
        public decimal? Salary { get; set; }
    }
}
