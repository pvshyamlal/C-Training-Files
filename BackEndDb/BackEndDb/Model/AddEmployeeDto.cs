namespace BackEndDb.Model
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }  //? means nullable(accepts null values)
        public decimal? Salary { get; set; }
    }
}
