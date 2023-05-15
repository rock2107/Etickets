using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinemalogo")]
        public string? Logo { get; set; }
        [Display(Name ="Cinema Name")]
        public string? FName { get; set; }
        [Display(Name = "Cinema Description")]
        public string? Description { get; set; }

        //relation
        public List<Movie>? Movies { get; set; }
    }
}
