using DTOLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class TalepModelValidator : AbstractValidator<TalepModelDTO>
    {
        public TalepModelValidator()
        {
            RuleFor(t => t.AliciIsimSoyisim).NotEmpty().NotNull().When(i => i.RadioForAlici == "1").WithMessage("Lütfen satıcı isim soyismini giriniz.");
            RuleFor(t => t.AliciMail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
            RuleFor(t => t.AliciTelNo).Length(10).WithMessage("Lütfen geçerli bir telefon numarası (10 haneli) giriniz.");

            RuleFor(t => t.MinFiyat).GreaterThan(0).WithMessage("Lütfen geçerli bir fiyat bilgisi giriniz");
            RuleFor(t => t.MaxFiyat).GreaterThan(0).WithMessage("Lütfen geçerli bir fiyat bilgisi giriniz");
            RuleFor(t => t.MinFiyat).LessThan(t=>t.MaxFiyat).WithMessage("Lütfen geçerli bir fiyat aralığı giriniz");

            RuleFor(t => t.Detaylar).MaximumLength(1000).WithMessage("Detay yazısı çok uzun.");
        }
    }
}
