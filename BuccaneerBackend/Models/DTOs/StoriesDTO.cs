namespace BuccaneerBanter.Models.DTOs;

public class StoryDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PirateId { get; set; }
    public string Content { get; set; }
    public string Date { get; set; }
    public PirateDTO Pirate { get; set; }

}