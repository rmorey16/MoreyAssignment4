using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment4.Models
{
    public class EntryResponse
    {
        [Required]
        public string personName { get; set; }
        [Required]
        public string restaurantName { get; set; }
        public string Dish { get; set; } = "It's all tasty!";
        [RegularExpression(@"^^[1-9]\d{2}-\d{3}-\d{4}",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string phoneNumber { get; set; }
        


    }
}
