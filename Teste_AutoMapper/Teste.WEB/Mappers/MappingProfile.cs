using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Entidades;
using Teste.WEB.Models.Cliente;

namespace Teste.WEB.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteConsultaViewModel>()
                .ForMember(cvw => cvw.Nome, map => map.MapFrom(c=> c.Nome))
                .ForMember(cvw => cvw.Sobrenome, map => map.MapFrom(c => c.Sobrenome))
                .ForMember(cvw => cvw.Ativo, map => map.MapFrom(c => c.Ativo))
                .ForMember(cvw => cvw.DataNascimento, map => map.MapFrom(c => c.DataNascimento))
                .ForMember(cvw=> cvw.NumeroDaSorte, opt => opt.Ignore());
        }
    }
}