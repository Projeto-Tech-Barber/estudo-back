using Moq;
using Surferbot.Application.UseCases.Contato;
using Surferbot.Application.Validators.ContatoValidador;
using Surferbot.Core.Entities.SurferbotContatos;
using Surferbot.Core.Exceptions;
using Surferbot.Infrastructure.Repositories.ContatoRepositorories;
using Surferbot.Test.Mocks.MocksContatos;
using Surferbot.Tests.Fixtures;

namespace Surferbot.Test.Application.UseCasesContatos;

public class ContatoUseCasesTests
{
    [Fact]
    public void CadastroContato_ChmarCreateDoRepositorio()
    {
        var mapper = MapperFixture.GetMapper();
        var validador = new ContatoValidador();

        var mockRepository = new Mock<IContatoRepository>();
        var service = new ContatoService(mapper, validador, mockRepository.Object);

        var dto = ContatoDtoMock.CriarContatoValido();

        service.CadastroContatos(dto);

        mockRepository.Verify(r => r.Create(It.IsAny<SurferbotContato>()), Times.Once);
    }
}
