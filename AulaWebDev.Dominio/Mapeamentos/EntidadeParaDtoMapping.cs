using AulaWebDev.Dominio.DTOs;
using AulaWebDev.Dominio.Entidades;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWebDev.Dominio.Mapeamentos
{
    public class EntidadeParaDtoMapping : Profile
    {
        public EntidadeParaDtoMapping()
        {
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
