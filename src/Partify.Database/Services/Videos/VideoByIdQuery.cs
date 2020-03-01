using CQRS.Query.Abstractions;
using System;
using Partify.Database.Tables;
using Partify.Shared.Models.YouTube;

namespace Partify.Database.Services.Videos
{
    public class VideoByIdQuery : IQuery<VideoTbl>
    {
        public Guid Id { get; set; }
    }
}