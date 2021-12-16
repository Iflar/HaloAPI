using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.FactionModels
{
    public class FactionCreate
    {
        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least 4 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string FactionName { get; set; }

        [MaxLength(100)]
        public string Motto { get; set; }

        public int YearActive { get; set;}

        [Required]
        [MinLength(5000, ErrorMessage = "Please enter more characters.")]
        [MaxLength(10000, ErrorMessage = "Too many characters in this field.")]
        public string Engagements { get; set; }


    }
}
