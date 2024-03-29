﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCases.CreateOrder
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderInputPort>
    {
        public CreateOrderValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty()
                .WithMessage("Debe proporcionar el identificador del cliente.");
            RuleFor(c => c.ShipAddress).NotEmpty()
                .WithMessage("Debe proporcionar la direccion de envio");
            RuleFor(c => c.ShipCity).NotEmpty().MinimumLength(3)
                .WithMessage("Debe proporcionar al menos 3 caracteres del nombre de la ciudad");
            RuleFor(c => c.ShipCountry).NotEmpty().MinimumLength(3)
                .WithMessage("Debe proporcionar al menos 3 caracteres del nombre del pais");
            RuleFor(c => c.OrdeDetails)
                .Must(d => d != null && d.Any())
                .WithMessage("Debe especificarse los productos de loa orden");
        }
    }
}
