using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(p => p.BlogTitle).NotEmpty().WithMessage("Blog basligini bos buraxmiyin");
            RuleFor(p => p.BlogContent).NotEmpty().WithMessage("Blog mesaji bos buraxmayin");
            RuleFor(p => p.BlogImage).NotEmpty().WithMessage("Blog sekillerin bos buraxmayin");

        }
    }
}
