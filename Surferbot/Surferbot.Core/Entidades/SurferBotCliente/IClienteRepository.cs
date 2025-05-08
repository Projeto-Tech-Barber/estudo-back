namespace Surferbot.Core.Entidades.SurferBotCliente
{
    public interface IClienteRepository
    {
        void Create(Cliente cliente);
        Cliente? Get(int id);

    }
}
