using Microsoft.EntityFrameworkCore;
using petryankin_daniil_kt_31_21.Models;
using petryankin_daniil_kt_31_21.Filters.StudentFilters;
using System.Net;

namespace petryankin_daniil_kt_31_21.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Произошло необработанное исключение.");

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var responseModel = new ResponseModel<object>
                {
                    Succeeded = false,
                    Message = "Произошла внутренняя ошибка сервера.",
                    Errors = new List<string> { exception.Message }
                };

                await context.Response.WriteAsJsonAsync(responseModel);
            }
        }
    }

    public class ResponseModel<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public T Data { get; set; }

        public ResponseModel() { }

        public ResponseModel(T data, string message = null)
        {
            Succeeded = true;
            Data = data;
            Message = message;
        }

        public ResponseModel(string message)
        {
            Succeeded = true;
            Message = message;
        }
    }

}
