using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWebApp.Entities
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]

        public string Image { get; set; }
        [Required]

        public string Type { get; set; }
        public string Extra { get; set; }
        [Required]

        public decimal NightPrice { get; set; }
    }
}
