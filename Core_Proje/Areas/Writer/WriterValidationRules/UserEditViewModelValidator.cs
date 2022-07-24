using FluentValidation;
using PersonalWebsite.Areas.Writer.Models;

namespace PersonalWebsite.Areas.Writer.WriterValidationRules
{
    public class UserEditViewModelValidator:AbstractValidator<UserEditViewModel>
    {
     public UserEditViewModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş bırakılamaz!");
            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("Parola alanı boş bırakılamaz!");
        }
    }
}
