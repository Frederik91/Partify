using System;
using Partify.Shared.Models.Spotify;

namespace Partify.Database.Services.Tracks
{
    public class CreateTrackCommand
    {
        public Guid Id { get; set; }
        public CreateTrackRequest Request { get; set; }
    }
}