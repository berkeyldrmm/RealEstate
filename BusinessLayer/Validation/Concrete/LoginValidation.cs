
using DTOLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation.Concrete
{
    public class LoginValidation : AbstractValidator<LoginModelDTO>
    {
        public LoginValidation()
        {
            RuleFor(l => l.Mail).NotNull().NotEmpty().WithMessage("Lütfen giriş yapabilmek için mail adresinizi giriniz.");
            RuleFor(l => l.Mail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
            RuleFor(l => l.Sifre).NotNull().NotEmpty().WithMessage("Lütfen giriş yapabilmek için şifrenizi giriniz.");
        }
    }
}
