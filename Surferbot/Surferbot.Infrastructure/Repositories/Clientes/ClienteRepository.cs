using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surferbot.Core.Entidades.SurferBotCliente;
using Surferbot.Infrastructure.Data;

namespace Surferbot.Infrastructure.Repositories.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SurferbotContext _surferbotContext;

        public ClienteRepository(SurferbotContext surferbotContext)
        {
            _surferbotContext = surferbotContext;
        }

        public void Create(Cliente cliente)
        {
            _surferbotContext.Add(cliente);
            _surferbotContext.SaveChanges();
        }

        public Cliente? Get(int id)
        {
            var cliente = _surferbotContext.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
            return cliente;
        }
    }
}
