using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TaxaJuros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Juros { get; set; }
    }
}
