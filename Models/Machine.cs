using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProCleaner.Models
{
    public class Machine
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Capacity { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }
        public string Material { get; set; }
        public int Weight { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(2, 1)")]
        public decimal Rating { get; set; }
    }
}