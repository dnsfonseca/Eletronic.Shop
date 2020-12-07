using AutoMapper;
using Eletronic.Shop.Dominio;
using Eletronic.Shop.Web.ViewModels.Product;
using Eletronic.Shop.Web.ViewModels.ProductProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eletronic.Shop.Web.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModel, Product>();
            Mapper.CreateMap<ProductProviderViewModel, ProductProvider>();
        }
    }
}