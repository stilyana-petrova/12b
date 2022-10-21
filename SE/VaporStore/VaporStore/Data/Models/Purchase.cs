using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models.Enum;

namespace VaporStore.Data.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public PurchaseType Type { get; set; }
        [Required]
        public string ProductKey { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
