using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Email must be an email address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="You must provide a Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
