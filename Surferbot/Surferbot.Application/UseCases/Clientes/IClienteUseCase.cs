using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Application.UseCases.Clientes
{
    public interface IClienteUseCase
    {
        void Criar(CriarClienteDto request);
        Cliente? Get(int id);





    }
}
