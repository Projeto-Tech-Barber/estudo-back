using FluentValidation;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Core.Exceptions;

namespace Surferbot.Application.Validadores.Clientes
{
    public class CriarClienteDtoValidator : AbstractValidator<CriarClienteDto>
    {
        public CriarClienteDtoValidator()
        {
            RuleFor(cliente => cliente.Nome).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_NOME);
            RuleFor(cliente => cliente.Email).EmailAddress().WithMessage(ResourceErrorMessages.ERRO_EMAIL);
            RuleFor(cliente => cliente.Cidade).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_CIDADE);
            RuleFor(cliente => cliente.Estado).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_ESTADO);
            RuleFor(cliente => cliente.Endereco).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_ENDERECO);
            RuleFor(cliente => cliente.Cep).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_CEP);
            RuleFor(cliente => cliente.Cpf).NotEmpty().NotNull().WithMessage(ResourceErrorMessages.ERRO_CPF);
            RuleFor(cliente => cliente.Cpf).IsValidCPF().WithMessage(ResourceErrorMessages.ERRO_CPF);
            RuleFor(cliente => cliente.Plano).IsInEnum().WithMessage(ResourceErrorMessages.ERRO_PLANO); 
        }
    }
}
