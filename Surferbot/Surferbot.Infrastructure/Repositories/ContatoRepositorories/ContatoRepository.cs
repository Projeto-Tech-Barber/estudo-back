using Surferbot.Core.Entities.SurferbotContatos;
using Surferbot.Infrastructure.Data;

namespace Surferbot.Infrastructure.Repositories.ContatoRepositorories;

public class ContatoRepository : IContatoRepository
{
    private readonly SurferbotContext _context;

    public ContatoRepository(SurferbotContext context)
    {
        _context = context;
    }
    public void Create(SurferbotContato Contato)
    {
        _context.Add(Contato);
        _context.SaveChanges();
    }
}
