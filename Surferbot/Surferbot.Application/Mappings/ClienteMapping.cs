using AutoMapper;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Application.Mappings
{
    public class ClienteMapping:Profile
    {
        public ClienteMapping()
        {
            CreateMap<Cliente, CriarClienteDto>().ReverseMap();



        }

    }
}
