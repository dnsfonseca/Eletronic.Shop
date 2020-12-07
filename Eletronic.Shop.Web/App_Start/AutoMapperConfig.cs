using AutoMapper;
using Eletronic.Shop.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eletronic.Shop.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar ()
        {
            Mapper.AddProfile<DomainToViewModelProfile>();
            Mapper.AddProfile<ViewModelToDomain>();
        }
    }
}