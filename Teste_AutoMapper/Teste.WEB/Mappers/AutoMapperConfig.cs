using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.WEB.Mappers
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            try
            {
                Mapper.Initialize(x =>
                {
                    x.AddProfile<MappingProfile>();
                    x.AddProfile<MappingViewModel>();
                });

                Mapper.Configuration.AssertConfigurationIsValid();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}