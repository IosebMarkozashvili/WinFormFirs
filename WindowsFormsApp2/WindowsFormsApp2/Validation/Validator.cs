using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Validation
{
   public class Validator
    {
        public class CustomerValidator : AbstractValidator<User>
        {
            public CustomerValidator()
            {
                RuleFor(x => x.Surname).NotEmpty().WithMessage("Please specify a  Surname").WithErrorCode("Error"); ;
                RuleFor(x => x.Name).NotEmpty().MaximumLength(10).MinimumLength(2).WithMessage("Please specify a  name").WithErrorCode("Error");
                RuleFor(x => x.Age).Must(o => o >= 18 && o < 100).NotNull().WithMessage("ასაკი განსაზღვრულია 18-დან 100წლამდე").WithErrorCode("ასაკი განსაზღვრულია 18-დან 100წლამდე"); ;

            }
        }
    }
}
