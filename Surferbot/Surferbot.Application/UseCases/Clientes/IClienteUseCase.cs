using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surferbot.Application.Modelos.Clientes;

namespace Surferbot.Application.UseCases.Clientes
{
    public interface IClienteUseCase
    {
        void Criar(CriarClienteDto request);
        




    }
}
