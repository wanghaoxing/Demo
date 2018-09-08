using AutoMapper;
using Core.Entities;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostDto>().ForMember(dest=>dest.UpdateTime,opt=>opt.MapFrom(src=>src.LastModified));

        }
    }
}
