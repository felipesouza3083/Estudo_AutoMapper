using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Entidades;
using Teste.WEB.Models.Cliente;

namespace Teste.WEB.Mappers
{
    public class MappingViewModel:Profile
    {
        public MappingViewModel()
        {
            CreateMap<ClienteConsultaViewModel, Cliente>()
                .ForMember(c => c.Nome, map => map.MapFrom(cvw => cvw.Nome))
                .ForMember(c => c.Sobrenome, map => map.MapFrom(cvw => cvw.Sobrenome))
                .ForMember(c => c.Ativo, map => map.MapFrom(cvw => cvw.Ativo))
                .ForMember(c => c.DataNascimento, map => map.MapFrom(cvw => cvw.DataNascimento));
        }
    }
}