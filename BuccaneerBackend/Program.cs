
using BuccaneerBanter.Models;
using BuccaneerBanter.Models.DTOs;

List<Pirate> pirates = new List<Pirate>
{
new()
{
     Id= 1,
      Name = "Blackbeard",
      Age = 42,
      Nationality = "English",
      Rank = "Captain",
      Ship= "Queen Anne's Revenge",
      ImageUrl= "https://photos1.blogger.com/blogger/5580/2256/1600/pirate-profile.0.jpg"
},
new()
{
     Id= 2,
      Name =  "Calico Jack",
      Age = 37,
      Nationality = "Irish",
      Rank = "Pirate",
      Ship= "Ranger",
      ImageUrl= "https://example.com/anne-bonny.jpg"
},
new()
{
     Id= 3,
      Name =  "Anne Bonny",
      Age =29,
      Nationality = "English",
      Rank = "Captain",
      Ship= "The Revenge",
      ImageUrl= "https://i.pinimg.com/736x/05/29/84/052984797e028fc5526ec780d80e93d7.jpg"

},
new()
{
     Id= 4,
      Name =  "Captain Kidd",
      Age =47,
      Nationality = "Scottish",
      Rank = "Captain",
      Ship="Adventure Galley",
      ImageUrl= "https://example.com/captain-kidd.jpg"

},
new()
{
     Id= 5,
      Name =  "Charles Vane",
      Age = 39,
      Nationality =  "English",
      Rank = "Captain",
      Ship="Ranger",
      ImageUrl= "https://avatarfiles.alphacoders.com/217/217786.jpg"

},
new()
{
     Id= 6,
      Name =  "Edward England",
      Age =  42,
      Nationality =  "Welsh",
      Rank = "Captain",
      Ship="Pearl",
      ImageUrl=  "https://example.com/edward-england.jpg"

},
new()
{
     Id= 7,
      Name =  "Edward Teach",
      Age =   38,
      Nationality = "English",
      Rank = "Captain",
      Ship="Queen Anne's Revenge",
      ImageUrl=  "https://example.com/edward-teach.jpg"

},
new()
{
     Id= 8,
      Name =  "Henry Avery",
      Age =  41,
      Nationality = "English",
      Rank = "Captain",
      Ship="Fancy",
      ImageUrl=  "https://example.com/henry-avery.jpg"

},
new()
{
     Id= 9,
      Name =  "Henry Morgan",
      Age =  53,
      Nationality = "Welsh",
      Rank = "Captain",
      Ship="Satisfaction",
      ImageUrl=  "https://example.com/henry-morgan.jpg"


},
new()
{
     Id= 10,
      Name = "Jack Rackham",
      Age =  37,
      Nationality =  "English",
      Rank = "Captain",
      Ship="The Revenge",
      ImageUrl=  "https://example.com/jack-rackham.jpg"


},
new()
{
     Id= 50,
      Name = "Mary Read",
      Age =  32,
      Nationality =  "English",
      Rank = "Pirate",
      Ship="Ranger",
      ImageUrl= "https://i.pinimg.com/originals/b7/c1/f1/b7c1f161dd713ec132b88d5350357030.jpg"


},
new()
{
     Id= 51,
      Name = "John Drake",
      Age =  40,
      Nationality =  "English",
      Rank = "Buccaneer",
      Ship="Blue Midnight",
      ImageUrl= "https://i.pinimg.com/originals/b7/c1/f1/b7c1f161dd713ec132b88d5350357030.jpg"


},
};

List<Story> stories = new List<Story>
{
    new()

   {
      Id= 2,
      PirateId= 8,
      Title= "The Ghost Ship",
      Content = "The crew of the merchant ship Mary Celeste were found mysteriously missing, leaving the ship and its valuable cargo untouched. It's been said that the ship still sails the seas, haunting those who cross its path.",
      Date = "1718-09-01"
    },
     new()
     {
        Id = 3,
      PirateId =  3,
      Title =  "The Kraken",
      Content = "The Kraken, a massive sea monster, has been the subject of many pirate tales. Its tentacles can stretch for miles and it can easily capsize even the largest ships. Many pirates have met their end at the hands of this fearsome creature.",
      Date =  "1718-11-22"
     },
     new()
     {
        Id =  149,
      PirateId = 50,
      Title = "The Curse of the Flying Dutchman",
      Content =  "Legend had it that the Flying Dutchman was cursed to sail the seas forever, its crew doomed to an eternal existence as undead pirates. But when a group of adventurers stumbled upon the ship one stormy night, they found that the curse was all too real. Now they must find a way to break the curse before it's too late.",
      Date = "1722-10-15"
     },
     new()
     {
        Id = 56,
      Title = "The Battle of Blackbeard's Bay",
      Content = "It was a fierce battle that raged on for hours. The sound of cannons and the clash of swords echoed across the bay. The pirates fought with all their might, determined to come out on top. In the end, it was Blackbeard's crew that emerged victorious, with a chest full of treasure to show for it.",
      PirateId = 2,
      Date ="1718-09-01"
     },
     new()
     {
        Id = 57,
      Title = "The Curse of the Kraken",
      Content = "Legend had it that the Kraken would rise from the depths of the ocean to claim any ship that sailed too close to its lair. The crew of the Black Pearl had heard the tales, but they didn't believe them. That was until they saw the monstrous creature rise from the waves, its tentacles reaching out to grab them. They fought with all their might, but in the end, only a few managed to escape with their lives.",
      PirateId = 5,
      Date ="1718-09-01"
     },
     new()
     {
        Id = 58,
      Title = "The Treasure of Captain Kidd",
      Content =  "Captain Kidd had buried his treasure on a deserted island, but he had left behind a map that would lead to its location. Many pirates had tried to find the treasure, but none had succeeded. That was until Captain Jack Sparrow got his hands on the map. He and his crew set sail for the island, and after days of searching, they finally found the treasure. It was more gold than they could ever have imagined.",
      PirateId =  3,
      Date = "1725-05-30"
     },
     new()
     {
        Id = 59,
      Title = "The Betrayal of Black Bart",
      Content = "Black Bart was known as one of the fiercest pirates on the high seas. His crew was loyal to him, and they would follow him to the ends of the earth. Or so he thought. One night, while they were anchored off the coast of Jamaica, his first mate led a mutiny against him. Bart fought bravely, but in the end, he was overpowered. He was left marooned on a deserted island, while his crew sailed off with all his treasure.",
      PirateId = 4,
      Date ="1722-06-22"
     },
     new()
     {
        Id = 60,
      Title = "The Revenge of Calico Jack",
      Content = "Calico Jack had been captured by the British Navy and sentenced to hang. But he managed to escape and vowed revenge against the captain who had betrayed him. He spent months planning his revenge, gathering a crew of loyal men and plotting his attack. Finally, the day arrived, and he and his crew stormed the captain's ship. They fought fiercely, but in the end, it was Calico Jack who emerged victorious. He sailed off into the sunset, a hero to his crew and a thorn in the side of the British Navy.",
      PirateId = 9,
      Date = "1742-08-15"
     }
};

List<Follower> followers = new List<Follower>
{
    new()
    {
        Id = 1,
      PirateId = 1,
      FollowerId = 2
    },
    new()
    {
        Id = 2,
      PirateId = 1,
      FollowerId = 3
    },
    new()
    {
        Id = 3,
      PirateId = 2,
      FollowerId = 1
    },
    new()
    {
        Id =  4,
      PirateId = 2,
      FollowerId = 3
    },
    new()
    {
        Id = 5,
      PirateId = 3,
      FollowerId = 1
    },
    new()
    {
        Id = 6,
      PirateId = 3,
      FollowerId = 2
    },
    new()
    {
      Id = 7,
      PirateId = 50,
      FollowerId = 2
    },
    new()
    {
        Id = 8,
      PirateId = 50,
      FollowerId = 3
    },
    new()
    {
        PirateId = 1,
      FollowerId = 1,
      Id = 9
    },
    new()
    {
        PirateId = 1,
      FollowerId = 1,
      Id = 10
    },
    new()
    {
        PirateId = 50,
      FollowerId = 5,
      Id = 13
    },
    new()
    {
        PirateId = 7,
      FollowerId = 5,
      Id = 14
    },
    new()
    {
    FollowerId = 1,
      PirateId = 8,
      Id = 15
    },
    new()
    {
     FollowerId = 1,
      PirateId = 50,
      Id = 16
    }
};




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/stories" , () => {
    return stories.Select(s => new StoryDTO
    {
        Id = s.Id,
        Title = s.Title,
        Pirate = new PirateDTO
        {
            Id = s.Pirate.Id,
            Name = s.Pirate.Name
        },
        Content = s.Content,
        Date = s.Date
    });
});

app.MapGet("/api/pirate/{id}", (int id) => {
Pirate pirate = pirates.FirstOrDefault(p => p.Id == id);
if (pirate == null) {
    return Results.NotFound();
}

return Results.Ok( new PirateDTO
    {
        Id = pirate.Id,
        Name = pirate.Name,
        Age = pirate.Age,
        Nationality = pirate.Nationality,
        Rank = pirate.Rank,
        Ship = pirate.Ship,
        ImageUrl = pirate.ImageUrl

    });
 });

app.Run();

