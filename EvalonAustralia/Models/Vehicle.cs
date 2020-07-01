using System.ComponentModel.DataAnnotations;

namespace EvalonAustralia.Models
{
    public class Vehicle
    {
        
        public int Id { get; set; }
        [Required (ErrorMessage ="Please Enter Vehicle Make")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Year of Make")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Kilometer")]
        [Display(Name ="Kilometer")]
        public int Kilometer { get; set; }
        [Display(Name ="Vehicle Photo")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Color")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Rate Per Day")]
        [Display(Name ="Vehicle Rate")]
        public decimal RatePerDay { get; set; }

        

    }
}