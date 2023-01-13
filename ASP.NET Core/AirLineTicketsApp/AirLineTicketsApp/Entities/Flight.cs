using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApp.Entities
{
    public class Flight
    {
        public Flight()
        {
            this.Reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }
        [Required]
        public int FlightNumber { get; set; }
        [Required]
        public string StartDestination { get; set; }
        [Required]
        public string FinalDestination { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime Final { get; set; }
        [Required]
        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        [Required]
        public decimal TicketPrice { get; set; }
        [Required]
        public double Discount { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
