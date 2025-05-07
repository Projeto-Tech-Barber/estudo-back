using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surferbot.Core.Entidades.SurferBotCliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public Plano Plano { get; set; }

    }
    public enum Plano
    {
        Infantil = 1,
        Adulto = 2,
        Profissional = 3,
    };
}
