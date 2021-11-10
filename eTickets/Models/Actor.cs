
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture URL is Required")]
        [Url(ErrorMessage = "Please enter a valid url")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage ="Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
