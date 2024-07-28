using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        [Required]
        public string? Description { get; set; }

    }
}
