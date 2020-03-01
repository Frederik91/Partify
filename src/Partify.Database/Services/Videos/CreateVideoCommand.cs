using Partify.Shared.Models.Spotify;
using System;

namespace Partify.Database.Services.Videos
{
    public class CreateVideoCommand
    {
        public Guid Id { get; set; }
        public CreateVideoRequest Request { get; set; }
    }
}