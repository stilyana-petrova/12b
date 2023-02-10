﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShowRoom.Entities
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string RegNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string Manufacturer { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        public string Picture { get; set; }
        public DateTime YearOfManufacture { get; set; }
        [Required]
        [Range(1000, 300000)]
        public double Price { get; set; }
    }
}
