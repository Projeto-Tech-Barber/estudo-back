namespace Surferbot.Core.Entidades.SurferBotCliente
{
    public class Cliente
    {
        public int Id { get; set; } 
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public Plano Plano { get; set; }

    }
    public enum Plano
    {
        Infantil = 1,
        Adulto = 2,
        Profissional = 3,
    };
}
