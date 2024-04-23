namespace BuccaneerBanter.Models;
public class Story
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PirateId { get; set; }
    public string Content { get; set; }
    public string Date { get; set; }
    public List<Pirate> Pirate {get; set;}

}