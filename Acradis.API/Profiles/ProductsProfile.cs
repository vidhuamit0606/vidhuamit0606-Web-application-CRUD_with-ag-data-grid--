using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acradis.API.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Entities.Product, Models.Product>();
                //.ForMember(dest => dest.Author, opt => opt.MapFrom(src =>
                //    $"{src.Author.FirstName} {src.Author.LastName}"));

            CreateMap<Models.ProductForCreation, Entities.Product>();
        }


    }
}
