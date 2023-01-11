using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWebApp.Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string EGN { get; set; }
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]

        public string Town { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
