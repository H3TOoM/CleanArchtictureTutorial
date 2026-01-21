using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Commands
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.Product.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");

            RuleFor(x => x.Product.Price)
                .GreaterThan(0).WithMessage("Product price must be positive.");

            RuleFor(x => x.Product.CategoryId)
                .NotEmpty().WithMessage("Category ID is required.");
        }
    }
}
