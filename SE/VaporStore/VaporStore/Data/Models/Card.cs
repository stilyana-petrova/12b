using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models.Enum;

namespace VaporStore.Data.Models
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public CardType Type { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
