﻿using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal value { get; set; }
        [Required]


        public string? Description {  get; set; }
    }
}
