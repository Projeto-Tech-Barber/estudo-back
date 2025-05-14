using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Surferbot.Application;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Application.UseCases.Clientes;
using Surferbot.Application.Validadores.Clientes;
using Surferbot.Core.Entidades.SurferBotCliente;
using Surferbot.Infrastructure.Data;
using Surferbot.Infrastructure.Repositories.Clientes;

namespace Testes.Clientes
{
    public class TestesCliente
    {
        private readonly IClienteUseCase _clienteUseCase;

        public TestesCliente()
        {
            CriarClienteDtoValidator clienteDtoValidator = new();

            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(ApplicationAssemblyReference).Assembly);
            });
            IMapper mapper = mockMapper.CreateMapper();

            var dboptions = new DbContextOptionsBuilder().UseInMemoryDatabase("Mydb");
            var surferbotContext = new SurferbotContext(dboptions.Options);
            IClienteRepository clienteRepository = new ClienteRepository(surferbotContext);

            _clienteUseCase = new ClienteUseCase(clienteDtoValidator, mapper, clienteRepository);
        }

        [Fact]
        public void Criar_ClienteInvalido_ThrowsValidationException()
        {
            var cliente = new CriarClienteDto();

            var invoker = () => _clienteUseCase.Criar(cliente);

            Assert.Throws<ValidationException>(invoker);

        }
        [Fact]
        public void Criar_ClienteValido_ReturnsSuccess()
        {
            var cliente = new CriarClienteDto()
            {
                Nome = "Testes",
                Cidade = "Testes",
                Cep = "49091040",
                Cpf = "704.380.718-24",
                Email = "testeemail@gmail.com",
                Endereco = "Teste Da Silva",
                Estado = "SantoTeste",
                Plano = Plano.Infantil,
            };

            _clienteUseCase.Criar(cliente);
            Assert.True(true);
        }
    }
}