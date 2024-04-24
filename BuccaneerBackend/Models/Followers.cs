using BuccaneerBanter.Models.DTOs;

namespace BuccaneerBanter.Models;
public class Follower
{
    public int Id { get; set; }
    public int PirateId { get; set; }
    public int FollowerId { get; set; }
    public Pirate pirate { get; set; }

}