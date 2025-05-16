using Surferbot.Core.Entities.SurferbotContatos;
using Surferbot.Infrastructure.Repositories.ContatoRepositorories;

namespace Surferbot.Test.Mocks.MocksContatos;

public class FakeContatoRepository : IContatoRepository
{
    public List<SurferbotContato> Contatos { get; private set; } = new();

    public void Create(SurferbotContato contato)
    {
        Contatos.Add(contato);
    }

    public IEnumerable<SurferbotContato> ObterTodos()
    {
        return Contatos;
    }
}
