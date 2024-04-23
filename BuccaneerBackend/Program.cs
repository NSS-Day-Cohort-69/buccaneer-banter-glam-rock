using BuccaneerBanter.Models;
using BuccaneerBanter.Models.DTOs;

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
Pirate pirate = pirates.FirstorDefault(p => p.Id == id);
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


