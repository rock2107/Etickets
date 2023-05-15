using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Producer
    {
        

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profilepicture")]
        public string? Profilepicture { get; set; }
        [Display(Name = "FullName")]
        public string? FullName { get; set; }
        [Display(Name = "Bio")]
        public string? Bio { get; set; }

        //Relaationship
        public List<Movie>? Movies { get; set;}
    }
}
