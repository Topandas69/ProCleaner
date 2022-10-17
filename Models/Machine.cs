using System;
using System.ComponentModel.DataAnnotations;

namespace ProCleaner.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Capacity { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
    }
}