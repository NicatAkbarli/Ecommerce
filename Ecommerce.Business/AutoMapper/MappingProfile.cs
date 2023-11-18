using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Entity.Dtos.CategoryCreateDtos;


namespace Ecommerce.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryCreateDto>().ReverseMap();
        }
    }
}