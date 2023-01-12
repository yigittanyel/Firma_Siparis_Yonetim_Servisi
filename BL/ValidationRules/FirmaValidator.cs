using EL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class FirmaValidator : AbstractValidator<Firma>
    {
        public FirmaValidator()
        {
            RuleFor(x => x.FirmaAdi).NotEmpty().WithMessage("Firma adı boş geçilemez!");
        }
    }
}
