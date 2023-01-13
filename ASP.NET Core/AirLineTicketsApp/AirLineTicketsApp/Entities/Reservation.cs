using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApp.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        [ForeignKey("Flight")]
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        [Required]
        public DateTime TicketReservation { get; set; }
        [Required]
        public int TicketsNum { get; set; }


    }
}
