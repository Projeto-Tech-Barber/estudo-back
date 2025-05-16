using Surferbot.Application.Validators.ContatoValidador;
using Surferbot.Tests.Fixtures;

namespace Surferbot.Test.Application.Validador;

public class ContatoValidadorTests
{
    private readonly ContatoValidador _validador = new ContatoValidador();

    [Fact]
    public void Validador_DadosInvalidos()
    {
        var dtoInvalido = ContatoDtoMock.CriarContatoInvalido();

        var resultado = _validador.Validate(dtoInvalido);

        Assert.False(resultado.IsValid);
        Assert.True(resultado.Errors.Count >= 2);
    }

    [Fact]
    public void Validador_DadosValidos()
    {
        var dtoValido = ContatoDtoMock.CriarContatoValido();

        var resultado = _validador.Validate(dtoValido);

        Assert.True(resultado.IsValid);
    }
}
