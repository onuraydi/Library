using FluentValidation;
using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.ValidationRules.FluentValidation
{     
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.BookTitle).NotEmpty().WithMessage("Kitap adı boş geçilemez!");
            RuleFor(p => p.Author).NotEmpty().WithMessage("Kitap yazarı boş geçilemez!");
            RuleFor(p => p.Category).NotEmpty().WithMessage("Kitap kategorisi boş geçilemez!"); // ilerleyen kısımlarda düzeltme yapılabilir
            RuleFor(p => p.Publisher).NotEmpty().WithMessage("Yayınevi boş geçilemez!");
            RuleFor(p => p.NumberOfPages).NotEmpty().WithMessage("Sayfa sayısı boş geçilemez!");
            RuleFor(p => p.StatusID).NotEmpty().WithMessage("Durum kısmı boş geçilemez!");

            RuleFor(p => p.NumberOfPages).GreaterThan(60).WithMessage("Sayfa sayısı 60'dan küçük olamaz!");
            RuleFor(p => p.BookTitle).MaximumLength(50).WithMessage("Kitap adı bu kadar uzun olamaz!");
            RuleFor(p => p.Author).MaximumLength(50).WithMessage("Yazar adı bu kadar uzun olamaz!");
            RuleFor(p => p.Category).MaximumLength(25).WithMessage("Kategori adı bu kadar uzun olamaz!");
            RuleFor(p => p.Publisher).MaximumLength(25).WithMessage("yayınevi adı bu kadar uzun olamaz!");
            RuleFor(p => p.Notes).MaximumLength(500).WithMessage("Not bu kadar uzun olamaz!");

            //bu kurallar arttırılabilir.
        }
    }
}
