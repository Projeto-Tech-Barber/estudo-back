using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surferbot.Core.Entidades.SurferBotCliente
{
    public interface IClienteRepository
    {
        void Create(Cliente cliente);
        Cliente? Get(int id);

    }
}
