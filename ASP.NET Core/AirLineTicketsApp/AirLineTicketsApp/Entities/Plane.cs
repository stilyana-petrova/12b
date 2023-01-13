using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApp.Entities
{
    public class Plane
    {
        public Plane()
        {
            this.Flights = new HashSet<Flight>();
        }
        public int Id { get; set; }
        [Required]
        public string PlaneCode { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public double Luggage { get; set; }
        [Required]
        public bool Bar { get; set; }
        [Required]
        public int Seats { get; set; }
        public ICollection<Flight> Flights { get; set; }

    }
}
