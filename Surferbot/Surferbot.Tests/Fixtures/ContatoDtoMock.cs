using Surferbot.Application.Dtos.ContatoDtos;

namespace Surferbot.Tests.Fixtures
{
    public static class ContatoDtoMock
    {
        public static ContatoDto CriarContatoValido()
        {
            return new ContatoDto
            {
                Nome = "Teste",
                Email = "teste@email.com",
                Mensagem = "Teste Mensagem"
            };
        }

        public static ContatoDto CriarContatoInvalido()
        {
            return new ContatoDto
            {
                Nome = "",
                Email = "email_invalido",
                Mensagem = ""
            };
        }
    }
}
