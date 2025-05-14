using AutoMapper;
using Surferbot.Application.Dtos.ContatoDtos;
using Surferbot.Core.Entities.SurferbotContatos;

namespace Surferbot.Api.SurferbotProfiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ContatoDto, SurferbotContato>().ReverseMap();
    }
}
