﻿using Etickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Etickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description  { get; set; }
        [Display(Name = "Price")]
        public double Price  { get; set; }
        [Display(Name = "ImageURL")]
        public string? ImageURL { get; set; }
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relation

        public List<Actor_Movie>? Actors_Movies { get; set;}
        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }
       
        
        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
