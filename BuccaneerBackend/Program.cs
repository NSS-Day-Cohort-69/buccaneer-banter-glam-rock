using System.Security.Cryptography;
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

app.MapGet("/stories" , () => {
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


// app.MapPost("/followers/{userId}", (int userId, int followerId) =>
// {
//     Pirate follower = pirates.FirstOrDefault(p => p.pirateId == userId);   
// });

app.Run();

