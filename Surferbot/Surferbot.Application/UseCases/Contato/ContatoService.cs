using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Surferbot.Application.Dtos.ContatoDtos;
using Surferbot.Application.Interface.InterfaceContato;
using Surferbot.Application.Validators.ContatoValidador;
using Surferbot.Core.Entities.SurferbotContatos;
using Surferbot.Core.Exceptions;
using Surferbot.Infrastructure.Data;
using Surferbot.Infrastructure.Repositories.ContatoRepositorories;

namespace Surferbot.Application.UseCases.Contato;

public class ContatoService : IContatoService
{
    private readonly IMapper _mapper;
    private readonly ContatoValidador _validador;
    private readonly IContatoRepository _repository;

    public ContatoService(IMapper mapper, ContatoValidador validador, IContatoRepository repository)
    {
        _mapper = mapper;
        _validador = validador;
        _repository = repository;
    }

    public void CadastroContatos(ContatoDto contatoDto)
    {
        var validadoResult = _validador.Validate(contatoDto);

        if (!validadoResult.IsValid)
        {
            var erros = validadoResult.Errors.Select(e => e.ErrorMessage);
            throw new ValidacaoException(erros);
        }

        try
        {
            var contato = _mapper.Map<SurferbotContato>(contatoDto);

            _repository.Create(contato);
        }
        catch (DbUpdateException dbEx)
        {
            throw new ConexaoException("Erro ao atualizar os dados no banco de dados.", dbEx);
        }
        catch (NpgsqlException npgsqlEx) 
        {
            throw new ConexaoException("Erro de conexão com o banco de dados PostgreSQL.", npgsqlEx);
        }
        catch (Exception ex) 
        {
            throw new Exception("Ocorreu um erro inesperado.", ex);
        }

    }
}
