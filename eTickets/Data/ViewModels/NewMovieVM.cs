using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Price is Required")]
        [Display(Name = "Price in $")]
        public double Price { get; set; }


        [Required(ErrorMessage = "Image Url is Required")]
        [Display(Name ="Movie Poster Url")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        [Display(Name = "Movie start Date")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "Movie end Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie Category is required")]
        [Display(Name = "Select a Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        [Required(ErrorMessage = "Movie Actor(s) is required")]
        [Display(Name = "Select Actor(s)")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Movie Cinema is required")]
        [Display(Name = "Select a Cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Movie producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }
    }
}
