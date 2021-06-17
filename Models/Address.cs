using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Zadanie2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = " To pole jest obowiązkowe!")]

        public string Street { get; set; }
        [RegularExpression(@"^\d{2}(-\d{3})?$", ErrorMessage = "Invalid Zip")]
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = " To pole jest obowiązkowe!")]
        [Display(Name = " City ")]
        public string City { get; set; }
        public int Number { get; set; }

    }
}
