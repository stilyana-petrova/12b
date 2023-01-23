using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DogGalery.Models
{
    public class DogCreateViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Age must be a positive number and lower than 30")]
        [Display(Name = "Age")]

        public int Age { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Breed")]

        public string Breed { get; set; }
        [Display(Name = "Dog Picture")]


        public string Picture { get; set; }
    }
}

