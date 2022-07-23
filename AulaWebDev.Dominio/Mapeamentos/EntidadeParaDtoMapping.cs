using AulaWebDev.Dominio.DTOs;
using AulaWebDev.Dominio.Entidades;
using AutoMapper;

namespace AulaWebDev.Dominio.Mapeamentos
{
    public class EntidadeParaDtoMapping : Profile
    {
        public EntidadeParaDtoMapping()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<Produto, ProdutoDto>();
        }
    }
}
