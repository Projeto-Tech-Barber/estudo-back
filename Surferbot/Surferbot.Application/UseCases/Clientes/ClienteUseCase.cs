using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Application.Validadores.Clientes;

namespace Surferbot.Application.UseCases.Clientes
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly CriarClienteDtoValidator validator;
        public ClienteUseCase(CriarClienteDtoValidator validator)
        {
            this.validator = validator;
        }
        public void Criar(CriarClienteDto request)
        {
            this.validator.ValidateAndThrow(request);


        }
    }
}
