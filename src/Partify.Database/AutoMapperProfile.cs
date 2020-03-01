using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Partify.Database.Tables;
using Partify.Shared.Models.Spotify;
using Partify.Shared.Models.YouTube;

namespace Partify.Database
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TrackTbl, TrackDto>();
            CreateMap<VideoTbl, VideoDto>();
        }
    }
}
