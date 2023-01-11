using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWebApp.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]

        public string RoomPic { get; set; }
        [Required]
        [ForeignKey("Client")]

        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]

        public DateTime ReservationDate { get; set; }
        [Required]

        public int Nights { get; set; }
    }
}
