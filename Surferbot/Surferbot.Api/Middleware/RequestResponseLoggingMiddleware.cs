using FluentValidation;
using Serilog;
using Surferbot.Application.Modelos;
using Surferbot.Core.Exceptions;

namespace Surferbot.Api.Middleware
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            string ip = context.Connection.RemoteIpAddress?.ToString() ?? "?";
            string endpoint = context.Request.Path.ToString();
            string info = $"IP da maquina: {ip} | Endpoint chamado: {endpoint}";
            try
            {
                Log.Information(info);
                await _next(context);
            }
            catch (ValidationException ex)
            {
                info += $" | Erro de validação: {ex.Message}";
                Log.Warning(info);
                List<string> mensagens = ex.Errors.Select(x => x.ErrorMessage).ToList();
                var erros = new ErrorValidationModel(mensagens);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(erros);
            }
            catch (DomainException ex)
            {
                info += $" | Erro de validação no dominio: {ex.Message}";
                Log.Error(info);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(ex.Message);
            }
            catch (ConexaoException ex)
            {
                info += $" | Erro de conexão no banco: {ex.Message}";
                Log.Error(info);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsJsonAsync(ex.Message);
            }
            catch (Exception ex)
            {
                info += $" | Erro desconhecido: {ex.Message}";
                Log.Error(info);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(ex.Message);
            }
            
        }
    }
}
