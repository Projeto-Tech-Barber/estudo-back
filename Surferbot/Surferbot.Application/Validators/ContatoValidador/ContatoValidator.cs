using FluentValidation;
using Surferbot.Application.Dtos.ContatoDtos;
using Surferbot.Core.Exceptions.ExceptionsContato;

namespace Surferbot.Application.Validators.ContatoValidador;

public class ContatoValidador : AbstractValidator<ContatoDto>
{
    public ContatoValidador()
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage(ResourceErrorMessages.Erro_Nome);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(ResourceErrorMessages.Erro_Email_)
            .EmailAddress().WithMessage(ResourceErrorMessages.Erro_Email_Invalido);

        RuleFor(x => x.Mensagem)
            .NotEmpty().WithMessage(ResourceErrorMessages.Erro_Mensagem);
    }
}
