using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidation:AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(p => p.WriterName).NotEmpty().WithMessage("Xana boş ola bilməz!");
            RuleFor(p => p.WriterName).MinimumLength(2).WithMessage("Minimum 2 simvoldan çoxolmalıdı");
            RuleFor(p => p.EmailAddress).NotEmpty().WithMessage("Xana boş ola bilməz!");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Xana boş ola bilməz!");
        }
    }
}
