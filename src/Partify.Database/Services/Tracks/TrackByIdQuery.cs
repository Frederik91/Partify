using CQRS.Query.Abstractions;
using System;
using Partify.Database.Tables;

namespace Partify.Database.Services.Tracks
{
    public class TrackByIdQuery : IQuery<TrackTbl>
    {
        public Guid Id { get; set; }
    }
}