using Surferbot.Core.Entities.SurferbotContatos;

namespace Surferbot.Infrastructure.Repositories.ContatoRepositorories;

public interface IContatoRepository
{
    void Create(SurferbotContato contato);
}
