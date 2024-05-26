using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Library.Library.Entities.Concrete;

namespace Library.Library.Business.ValidationRules.FluentValidation
{
    public class MagazineValidator:AbstractValidator<Magazine>
    {
        public MagazineValidator() 
        {
            RuleFor(p => p.MagazineName).NotEmpty().WithMessage("Dergi adı Boş olamaz!");
            RuleFor(p => p.MagazineCategory).NotEmpty().WithMessage("Dergi türü Boş olamaz!");
            RuleFor(p => p.Issue).NotEmpty().WithMessage("Dergi sayısı Boş olamaz!");
            RuleFor(p => p.NumberOfPages).NotEmpty().WithMessage("Dergi sayfa sayısı Boş olamaz!");

            RuleFor(p => p.MagazineName).MaximumLength(50).WithMessage("Dergi adı bu kadar uzun olamaz!");
            RuleFor(p => p.MagazineCategory).MaximumLength(20).WithMessage("Kategori adı bu kadar uzun olamaz!");
            RuleFor(p => p.Issue).MaximumLength(30).WithMessage("Dergi sayısı bu kadar uzun olamaz!");
            RuleFor(p => p.NumberOfPages).GreaterThan(30).WithMessage("Dergi sayfası 30'dan küçük olamaz!");

        }
    }
}
