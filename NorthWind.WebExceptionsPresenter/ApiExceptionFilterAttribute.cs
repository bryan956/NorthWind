using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.WebExceptionsPresenter
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        readonly IDictionary<Type, IExcptionHandler> ExceptionHandlers;

        public ApiExceptionFilterAttribute(
            IDictionary<Type, IExcptionHandler> exceptionHandler) => ExceptionHandlers = exceptionHandler;

        public override void OnException(ExceptionContext context)
        {
            Type ExceptionsType = context.Exception.GetType();
            if(ExceptionHandlers.ContainsKey(ExceptionsType))
            {
                ExceptionHandlers[ExceptionsType].Handler(context);
            }
            else
            {
                new ExceptionHandlerBase().SetResult(context,StatusCodes.Status500InternalServerError, "Ha ocurrido un proceso al procesar la respuesta.", "")
            }
            base.OnException(context);
        }
    }
}
