using DTOLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ChangePasswordModelValidator : AbstractValidator<ChangePasswordModelDTO>
    {
        public ChangePasswordModelValidator()
        {
            RuleFor(cpm => cpm.OldPassword).NotEmpty().NotNull().WithMessage("Lütfen mevcut şifrenizi giriniz.");
            RuleFor(cpm => cpm.NewPassword).NotEmpty().NotNull().WithMessage("Lütfen yeni şifrenizi giriniz.");
            RuleFor(cpm => cpm.CheckNewPassword).Equal(cpm=>cpm.NewPassword).WithMessage("Şifreler uyuşmuyor.");
        }
    }
}
