using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using NorthWind.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.WebExceptionsPresenter
{
    public class ValidationExceptionHandler : ExceptionHandlerBase, IExcptionHandler
    {
        public Task Handler(ExceptionContext context)
        {
            var Exception = context.Exception as ValidationException;
            StringBuilder Builder= new StringBuilder();
            foreach (var Failture in Exception.Errors)
            {
                Builder.Append(
                    string.Format("Propiedad: {0}. Error: {1}",
                    Failture.PropertyName, Failture.ErrorMessage));
            }
            return SetResult(context, StatusCodes.Status400BadRequest, "Error en los datos de entrada", Builder.ToString());
        }
    }
}
