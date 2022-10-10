using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Kateqori Adi daxil edin");
            RuleFor(p => p.CategoryDescription).NotEmpty().WithMessage("Bu alani bos gecemessin");
        }
    }
}
