using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Application.Modelos.Clientes
{
    public class CriarClienteDto
    {
        public  string Nome { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public  string Cpf { get; init; } = string.Empty;
        public  string Endereco { get; init; } = string.Empty;
        public  string Estado { get; init; } = string.Empty;
        public  string Cidade { get; init; } = string.Empty;
        public  string Cep { get; init; } = string.Empty;
        public  Plano Plano { get; init; }
    }
}
