using BuccaneerBanter.Models.DTOs;

namespace BuccaneerBanter.Models;
public class Story
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PirateId { get; set; }
    public string Content { get; set; }
    public string Date { get; set; }
<<<<<<< HEAD
    public Pirate Pirate { get; set; }
=======
    public Pirate Pirate {get; set;}
>>>>>>> 41f922ac84db6f79eb666a5339afe62a686dd030

}