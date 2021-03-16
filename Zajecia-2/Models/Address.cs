using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Zajecia._2.Models
{
    public class Address
    {
        [Display(Name = "Nazwa Twojej Ulicy")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }
        [Display(Name = "Twoje miasto")]
        public string ZipCode { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string City { get; set; }
        [Display(Name = "Numer domu")]
        public int Number { get; set; }
    }

}
