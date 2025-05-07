using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surferbot.Core.Entidades;
using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Application.Modelos.Clientes
{
    public class CriarClienteDto
    {
        public  string Nome { get; init; }
        public  string Email { get; init; }
        public  string Cpf { get; init; }
        public  string Endereco { get; init; }
        public  string Estado { get; init; }
        public  string Cidade { get; init; }
        public  string Cep { get; init; }
        public  Plano Plano { get; init; }
    }
}
