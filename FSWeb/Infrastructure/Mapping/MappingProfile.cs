using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Data.Models;
using FSWeb.Models;
using FSWeb.Models.ViewModels;

namespace FSWeb.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryUI>().ReverseMap();
            CreateMap<Item, ItemUI>().ReverseMap();
            CreateMap<ItemSummary, ItemSummaryVM>().ReverseMap();
        }
    }
}
