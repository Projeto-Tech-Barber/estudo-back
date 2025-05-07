using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surferbot.Core.Entidades;
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
