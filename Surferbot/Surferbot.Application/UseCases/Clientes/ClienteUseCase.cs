using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Application.Validadores.Clientes;
using Surferbot.Core.Entidades;
using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Application.UseCases.Clientes
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository; 
        private readonly CriarClienteDtoValidator validator;
        private readonly IMapper _mapper;
        public ClienteUseCase(CriarClienteDtoValidator validator, IMapper mapper, IClienteRepository clienteRepository)
        {
            this.validator = validator;
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }
        public void Criar(CriarClienteDto request)
        {
            this.validator.ValidateAndThrow(request);

            var cliente = _mapper.Map<Cliente>(request);

            _clienteRepository.Create(cliente);
        }

        public Cliente? Get(int id)
        {
            var cliente = _clienteRepository.Get(id);
            return cliente;
        }
    }
}
