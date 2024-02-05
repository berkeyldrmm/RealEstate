using DTOLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class IlanModelValidator : AbstractValidator<IlanModelDTO>
    {
        public IlanModelValidator()
        {
            RuleFor(i => i.SaticiIsimSoyisim).NotEmpty().NotNull().When(i => i.RadioForSatici == "1").WithMessage("Lütfen satıcı isim soyismini giriniz.");
            RuleFor(i => i.IlanBaslik).NotEmpty().NotNull().WithMessage("Lütfen ilan için bir başlık giriniz.");
            RuleFor(i => i.SaticiMail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
            RuleFor(i => i.SaticiTelNo).Length(10).WithMessage("Lütfen geçerli bir telefon numarası (10 haneli) giriniz.");

            RuleFor(i => i.Fiyat).GreaterThan(0).WithMessage("Lütfen geçerli bir fiyat bilgisi giriniz");

            RuleFor(i => i.Detaylar).MaximumLength(1000).WithMessage("Detay yazısı çok uzun.");
        }
    }
}
